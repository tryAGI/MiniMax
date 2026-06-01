#!/usr/bin/env bash
set -euo pipefail

repo_root="$(cd "$(dirname "${BASH_SOURCE[0]}")/.." && pwd)"
env_path="$repo_root/.env"

if [[ -z "${MINIMAX_API_KEY:-}" && -f "$env_path" ]]; then
  set -a
  source "$env_path"
  set +a
fi

if [[ -z "${MINIMAX_API_KEY:-}" ]]; then
  echo "MINIMAX_API_KEY is not set. Export it or place it in $env_path."
  exit 64
fi

model="${1:-music-2.6-free}"
prompt="${MINIMAX_SMOKE_PROMPT:-Short instrumental piano loop, clean ending, no vocals.}"

payload="$(MODEL="$model" PROMPT="$prompt" python3 - <<'PY'
import json
import os

print(json.dumps({
    "model": os.environ["MODEL"],
    "prompt": os.environ["PROMPT"],
    "is_instrumental": True,
    "output_format": "url",
}))
PY
)"

response_file="$(mktemp)"
trap 'rm -f "$response_file"' EXIT

http_code="$(curl -sS -o "$response_file" -w '%{http_code}' https://api.minimaxi.com/v1/music_generation \
  -H "Authorization: Bearer $MINIMAX_API_KEY" \
  -H 'Content-Type: application/json' \
  -d "$payload")"

HTTP_CODE="$http_code" RESPONSE_FILE="$response_file" MODEL="$model" python3 - <<'PY'
import json
import os
import sys

http_code = int(os.environ["HTTP_CODE"])
response_path = os.environ["RESPONSE_FILE"]
model = os.environ["MODEL"]

with open(response_path, "r", encoding="utf-8") as handle:
    body = handle.read().strip()

try:
    data = json.loads(body) if body else {}
except json.JSONDecodeError:
    print(f"HTTP {http_code}: non-JSON response")
    if body:
        print(body)
    sys.exit(1)

base_resp = data.get("base_resp") or {}
status_code = base_resp.get("status_code")
status_msg = str(base_resp.get("status_msg") or "")
trace_id = data.get("trace_id")
audio = ((data.get("data") or {}).get("audio"))

details = []
if status_code is not None:
    details.append(f"status_code={status_code}")
if status_msg:
    details.append(f"status_msg={status_msg}")
if trace_id:
    details.append(f"trace_id={trace_id}")

suffix = f" ({', '.join(details)})" if details else ""

if http_code == 200 and status_code in (None, 0) and audio:
    print(f"OK: {model} accepted the key and returned audio metadata{suffix}")
    print(f"audio={audio}")
    sys.exit(0)

msg = status_msg.lower()

if http_code == 401 or status_code in {1004, 2049} or "invalid api key" in msg:
    print(f"INVALID KEY: MiniMax rejected the credential{suffix}")
    sys.exit(2)

if status_code == 1008 or "balance" in msg or "余额" in status_msg:
    print(f"BILLING: MiniMax reports insufficient balance{suffix}")
    sys.exit(3)

if http_code == 429 or status_code in {1002, 2045, 2056} or "rate" in msg or "频率" in status_msg:
    print(f"RATE LIMIT: MiniMax rejected the request due to current limits{suffix}")
    sys.exit(4)

print(f"UNCLASSIFIED FAILURE: request did not succeed{suffix}")
if body:
    print(body)
sys.exit(1)
PY
