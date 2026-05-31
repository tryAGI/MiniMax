# CLAUDE.md -- MiniMax SDK

## Overview

Auto-generated C# SDK for the [MiniMax Platform](https://platform.minimaxi.com/) --
covers image generation, Hailuo video generation, music and lyrics generation,
text-to-speech, voice workflows, and file management.

**Scope:**

- **Image** -- shared `/v1/image_generation` endpoint for text-to-image and image-to-image generation.
- **Video** -- Hailuo 2.3 / 2.3-Fast / 02 text-to-video, image-to-video, start-end, subject reference (async task pattern: POST + poll).
- **Music** -- `music-2.6` / `music-cover` generation, music-cover preprocess, and lyrics generation.
- **Speech** -- T2A v2 text-to-speech, async TTS, voice clone, voice design, and voice management.
- **Files** -- upload/retrieve/download/list/delete (used as inputs for voice clone, async TTS, and generated assets).

**Excluded** (use another SDK):

- LLM chat completions -- use `tryAGI.OpenAI.CustomProviders.Minimax(...)` for the OpenAI-compatible chat endpoint.
- Embeddings -- MiniMax embeddings are chat-adjacent; use an LLM-focused SDK if needed.
- WebSocket TTS streaming -- not yet modelled; REST T2A v2 `stream=true` still works.

**No public bundled OpenAPI spec exists** -- `openapi.yaml` is handcrafted from [platform.minimaxi.com/docs](https://platform.minimaxi.com/docs).

## Build & Test

```bash
dotnet build MiniMax.slnx
dotnet test src/tests/IntegrationTests/
```

Tests skip (`AssertInconclusiveException`) when `MINIMAX_API_KEY` is missing.

## Auth

Standard Bearer token. Get an API key from
<https://platform.minimaxi.com/user-center/basic-information/interface-key>.

```csharp
using var client = new MiniMaxClient(apiKey); // MINIMAX_API_KEY env var
```

## Base URL

- Default: `https://api.minimaxi.com`

Pass `baseUri` to the constructor to override it.

## Sub-Client Layout

| Sub-client | Endpoints | Purpose |
|---|---|---|
| `client.Image` | `POST /v1/image_generation` | Text-to-image and image-to-image generation |
| `client.Video` | `POST /v1/video_generation`, `GET /v1/query/video_generation` | Hailuo video tasks |
| `client.Music` | `POST /v1/music_generation`, `POST /v1/music_cover_preprocess`, `POST /v1/lyrics_generation` | Music and lyrics workflows |
| `client.Speech` | `POST /v1/t2a_v2`, `POST /v1/t2a_async_v2`, `POST /v1/voice_clone`, `POST /v1/voice_design`, `POST /v1/get_voice`, `POST /v1/delete_voice` | Speech and voice workflows |
| `client.Files` | `POST/GET /v1/files/{upload,retrieve,list,retrieve_content,delete}` | File management |

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

- **Enum naming:** `VideoGenerationRequestResolution.x1080p`, `ImageGenerationRequestAspectRatio.x16_9`, and similar enums are prefixed when values start with digits.
- **Resolution per model:** the documented matrix now centers on `720P`, `768P`, and `1080P`. Check the platform docs before relying on a specific model/resolution pairing.
- **Audio output:** default is `hex` (inline hex-encoded bytes). Pass `outputFormat: *OutputFormat.Url` for a downloadable link.
- **Voice clone prerequisite:** upload the reference audio (MP3/M4A/WAV, 10s-5min) via `client.Files.UploadFileAsync(purpose: "voice_clone", ...)` first, then pass the numeric `file_id` to `CreateVoiceCloneAsync`.
- **CLS compliance:** extension methods returning `AIFunction` are marked `[CLSCompliant(false)]` because `Microsoft.Extensions.AI.AIFunction` is not CLS-compliant.
