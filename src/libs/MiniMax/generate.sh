#!/usr/bin/env bash
set -euo pipefail

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

# MiniMax Platform has no public bundled OpenAPI spec — `openapi.yaml` is
# handcrafted from the published docs at https://platform.minimax.io/docs.
#
# Scope: Image, Video (Hailuo + templates), Music, Lyrics, TTS, Async TTS,
# Voice Clone, Voice Design/Management, and Files.
# LLM chat completions are excluded — use `tryAGI.OpenAI.CustomProviders.Minimax`.
#
# Auth: standard Bearer token from
# platform.minimax.io/user-center/basic-information/interface-key.
install_autosdk_cli
rm -rf Generated

autosdk generate openapi.yaml \
  --namespace MiniMax \
  --clientClassName MiniMaxClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer
