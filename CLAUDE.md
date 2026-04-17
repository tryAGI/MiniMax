# CLAUDE.md -- MiniMax SDK

## Overview

Auto-generated C# SDK for the [MiniMax Platform](https://platform.minimax.io/) --
covers Hailuo video generation, music generation, text-to-speech (T2A v2),
voice cloning, and file management.

**Scope:**

- **Video** -- Hailuo 2.3 / 2.3-Fast / 02 text-to-video, image-to-video, start-end, subject reference (async task pattern: POST + poll).
- **Music** -- `music-2.6` / `music-cover` / `music-2.0` generation.
- **Speech** -- T2A v2 text-to-speech (`speech-2.8-hd`, `speech-2.8-turbo`, `speech-2.6-*`, `speech-02-*`, `speech-01-*`) + voice clone.
- **Files** -- upload/retrieve/list/delete (used as inputs for voice clone, music cover, video start frames).

**Excluded** (use another SDK):

- LLM chat completions -- use `tryAGI.OpenAI.CustomProviders.Minimax(...)` for the OpenAI-compatible chat endpoint.
- Embeddings -- MiniMax embeddings are chat-adjacent; use an LLM-focused SDK if needed.
- WebSocket TTS streaming -- not yet modelled; REST T2A v2 `stream=true` still works.

**No public OpenAPI spec exists** -- `openapi.yaml` is handcrafted from [platform.minimax.io/docs](https://platform.minimax.io/docs).

## Build & Test

```bash
dotnet build MiniMax.slnx
dotnet test src/tests/IntegrationTests/
```

Tests skip (`AssertInconclusiveException`) when `MINIMAX_API_KEY` is missing.

## Auth

Standard Bearer token. Get an API key from
<https://platform.minimax.io/user-center/basic-information/interface-key>.

```csharp
using var client = new MiniMaxClient(apiKey); // MINIMAX_API_KEY env var
```

## Base URL

- Default: `https://api.minimax.io` (global)
- China mainland: `https://api.minimaxi.chat`

Switch via `client.TrySelectServer("https-api-minimaxi-chat")` or pass
`baseUri` to the constructor.

## Sub-Client Layout

| Sub-client | Endpoints | Purpose |
|---|---|---|
| `client.Video` | `POST /v1/video_generation`, `GET /v1/query/video_generation` | Hailuo video tasks |
| `client.Music` | `POST /v1/music_generation` | Music generation |
| `client.Speech` | `POST /v1/t2a_v2`, `POST /v1/voice_clone` | TTS + voice cloning |
| `client.Files` | `POST/GET /v1/files/{upload,retrieve,list,delete}` | File management |

## Async Video Task Pattern

```csharp
// 1. Submit
var create = await client.Video.CreateVideoGenerationTaskAsync(
    model: "MiniMax-Hailuo-2.3",
    prompt: "A drone shot of mountains at sunrise",
    duration: 6,
    resolution: VideoGenerationRequestResolution.x1080p);

// 2. Poll (Preparing -> Queueing -> Processing -> Success)
while (true)
{
    var status = await client.Video.GetVideoGenerationTaskAsync(create.TaskId!);
    if (status.Status is VideoTaskStatus.Success or VideoTaskStatus.Fail)
        break;
    await Task.Delay(TimeSpan.FromSeconds(10));
}

// 3. Retrieve file URL
var file = await client.Files.RetrieveFileAsync(status.FileId!);
// file.File.DownloadUrl
```

## MEAI Integration

AIFunction tools for use with any `IChatClient` (via `MiniMaxToolExtensions`):

- `AsCreateVideoTaskTool()` -- submit a Hailuo video task
- `AsGetVideoTaskTool()` -- poll a video task by ID
- `AsGenerateMusicTool()` -- generate music from prompt/lyrics
- `AsSynthesizeSpeechTool()` -- T2A v2 speech synthesis
- `AsCloneVoiceTool()` -- create a voice clone from an uploaded file

No dedicated `IChatClient` / `IEmbeddingGenerator` / `ISpeechToTextClient`
implementation -- T2A v2 does synthesis only, not transcription. Chat goes
through `tryAGI.OpenAI.CustomProviders.Minimax(...)`.

## Key Files

- `src/libs/MiniMax/openapi.yaml` -- Handcrafted OpenAPI spec
- `src/libs/MiniMax/generate.sh` -- Regen script (runs `autosdk` on local spec)
- `src/libs/MiniMax/Generated/` -- **Never edit** -- auto-generated code
- `src/libs/MiniMax/Extensions/MiniMaxClient.Tools.cs` -- MEAI `AIFunction` tools
- `src/tests/IntegrationTests/Examples/` -- Example tests (also generate docs)

## Notes & Gotchas

- **Enum naming:** `VideoGenerationRequestResolution.x1080p` / `x768p` / `x512p` (AutoSDK prepends `x` when enum values start with digits).
- **Resolution per model:** Hailuo-2.3 supports 512P/768P/1080P, Hailuo-2.3-Fast is 768P only, Hailuo-02 supports 768P/1080P -- check the platform docs for the exact matrix before each release.
- **Audio output:** default is `hex` (inline hex-encoded bytes). Pass `outputFormat: *OutputFormat.Url` for a downloadable link.
- **Voice clone prerequisite:** upload the reference audio (MP3/M4A/WAV, 10s-5min) via `client.Files.UploadFileAsync(purpose: "voice_clone", ...)` first, then pass the returned `file_id` to `CreateVoiceCloneAsync`.
- **CLS compliance:** extension methods returning `AIFunction` are marked `[CLSCompliant(false)]` because `Microsoft.Extensions.AI.AIFunction` is not CLS-compliant.
