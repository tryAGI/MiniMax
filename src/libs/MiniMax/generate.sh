#!/usr/bin/env bash
set -euo pipefail

# MiniMax Platform has no public OpenAPI spec — `openapi.yaml` is handcrafted
# from the published docs at https://platform.minimax.io/docs.
#
# Scope: Video (Hailuo), Music, TTS (T2A v2), Voice Clone, Files.
# LLM chat completions are excluded — use `tryAGI.OpenAI.CustomProviders.Minimax`.
#
# Auth: standard Bearer token from platform.minimax.io/user-center/basic-information/interface-key.

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated

autosdk generate openapi.yaml \
  --namespace MiniMax \
  --clientClassName MiniMaxClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer
