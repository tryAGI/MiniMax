<div class="docs-hero">
  <h1>MiniMax</h1>
  <p class="docs-hero-lead">Modern .NET SDK for MiniMax generated from the provider's OpenAPI definition with AutoSDK.</p>
  <div class="docs-badge-row">
    <a href="https://www.nuget.org/packages/MiniMax/"><img alt="Nuget package" src="https://img.shields.io/nuget/vpre/MiniMax"></a>
    <a href="https://github.com/tryAGI/MiniMax/actions/workflows/dotnet.yml"><img alt="dotnet" src="https://github.com/tryAGI/MiniMax/actions/workflows/dotnet.yml/badge.svg?branch=main"></a>
    <a href="https://github.com/tryAGI/MiniMax/blob/main/LICENSE.txt"><img alt="License: MIT" src="https://img.shields.io/github/license/tryAGI/MiniMax"></a>
    <a href="https://discord.gg/Ca2xhfBf3v"><img alt="Discord" src="https://img.shields.io/discord/1115206893015662663?label=Discord&amp;logo=discord&amp;logoColor=white&amp;color=d82679"></a>
  </div>
  <div class="docs-hero-actions">
    <a href="#usage">Get started</a>
    <a href="#support">Get support</a>
  </div>
</div>

<div class="docs-feature-grid">
  <div class="docs-feature-card">
    <h3>Generated from the source spec</h3>
    <p>Built from a hand-maintained OpenAPI definition derived from <a href="https://platform.minimaxi.com/docs">MiniMax's published API documentation</a> so the SDK stays close to the upstream API surface.</p>
  </div>
  <div class="docs-feature-card">
    <h3>Auto-updated</h3>
    <p>Designed for fast regeneration and low-friction updates when the upstream API changes without breaking compatibility.</p>
  </div>
  <div class="docs-feature-card">
    <h3>Modern .NET</h3>
    <p>Targets current .NET practices including nullability, trimming, NativeAOT awareness, and source-generated serialization.</p>
  </div>
  <div class="docs-feature-card">
    <h3>Docs from examples</h3>
    <p>Examples stay in sync between the README, MkDocs site, and integration tests through the AutoSDK docs pipeline.</p>
  </div>
</div>

## Usage

```csharp
using MiniMax;

using var client = new MiniMaxClient(apiKey);
```

## Local Validation

Validate a local key against MiniMax's documented free music model without running the full integration suite:

```bash
./scripts/smoke-minimax-key.sh
```

To let local integration tests read a repo-local `.env` while keeping CI on normal environment secrets, opt in explicitly:

```bash
MINIMAX_LOAD_DOTENV=1 dotnet test src/tests/IntegrationTests/
```

<!-- EXAMPLES:START -->
### Create a video generation task
Submits a Hailuo video generation task and returns the `task_id`.

```csharp
using var client = new MiniMaxClient(apiKey);

var response = await client.Video.CreateVideoGenerationTaskAsync(
    model: "MiniMax-Hailuo-2.3",
    prompt: "A cinematic drone shot of a mountain range at sunrise, mist curling through the valleys.",
    duration: 6,
    resolution: VideoGenerationRequestResolution.x1080p);

Console.WriteLine($"task_id: {response.TaskId}");
```

### Generate images from text
Generates one or more images with MiniMax's shared image endpoint and returns image URLs.

```csharp
using var client = new MiniMaxClient(apiKey);

var response = await client.Image.CreateImageGenerationAsync(
    model: "image-01",
    prompt: "A clean product photo of a matte black mechanical keyboard on a walnut desk, soft studio lighting, photorealistic.",
    aspectRatio: ImageGenerationRequestAspectRatio.x16_9,
    responseFormat: ImageGenerationRequestResponseFormat.Url,
    n: 1,
    promptOptimizer: true);

Console.WriteLine($"image_url: {response.Data?.ImageUrls?.FirstOrDefault()}");
```

### Generate images from a reference image
Uses the same image endpoint with `subject_reference` to perform image-to-image generation.

```csharp
using var client = new MiniMaxClient(apiKey);

var response = await client.Image.CreateImageGenerationAsync(
    model: "image-01",
    prompt: "Turn this portrait into a cinematic magazine cover with warm golden-hour lighting and shallow depth of field.",
    subjectReference:
    [
        new ImageSubjectReference
        {
            Type = ImageSubjectReferenceType.Character,
            ImageFile = "https://cdn.hailuoai.com/prod/2025-08-12-17/video_cover/1754990600020238321-411603868533342214-cover.jpg",
        },
    ],
    responseFormat: ImageGenerationRequestResponseFormat.Url,
    n: 1);

Console.WriteLine($"image_url: {response.Data?.ImageUrls?.FirstOrDefault()}");
```

### Synthesize speech (T2A v2)
Uses T2A v2 to synthesize speech from text and returns a downloadable URL.

```csharp
using var client = new MiniMaxClient(apiKey);

var response = await client.Speech.CreateTextToSpeechAsync(
    model: "speech-2.6-turbo",
    text: "Hello from MiniMax T2A version 2. This is a test of the synthesis pipeline.",
    voiceSetting: new TtsVoiceSetting
    {
        VoiceId = "male-qn-qingse",
        Speed = 1.0f,
        Emotion = TtsVoiceSettingEmotion.Calm,
    },
    outputFormat: TextToSpeechRequestOutputFormat.Url);

Console.WriteLine($"audio: {response.Data?.Audio}");
Console.WriteLine($"length_ms: {response.ExtraInfo?.AudioLength}");
```

### Generate music
Generates an instrumental track with music-2.6 and returns a downloadable URL.

```csharp
using var client = new MiniMaxClient(apiKey);

var response = await client.Music.CreateMusicGenerationAsync(
    model: "music-2.6",
    prompt: "Upbeat electronic track with driving drums and shimmering synths, 120 bpm, hopeful mood.",
    isInstrumental: true,
    outputFormat: MusicGenerationRequestOutputFormat.Url);

Console.WriteLine($"audio: {response.Data?.Audio}");
Console.WriteLine($"duration_ms: {response.ExtraInfo?.MusicDuration}");
```

### MEAI AIFunction tools
Exposes MiniMax video, music, TTS, and voice-clone endpoints as MEAI
AIFunctions so they can be attached to any IChatClient.

```csharp
using var client = new MiniMaxClient(apiKey);

AIFunction[] tools =
[
    client.AsCreateVideoTaskTool(),
    client.AsGetVideoTaskTool(),
    client.AsGenerateMusicTool(),
    client.AsSynthesizeSpeechTool(),
    client.AsCloneVoiceTool(),
];

Console.WriteLine(string.Join(", ", tools.Select(t => t.Name)));
```
<!-- EXAMPLES:END -->

<!-- AUTOSDK:ECOSYSTEM-MAINTENANCE:START -->
## Ecosystem maintenance

This SDK is one of more than 200 .NET SDKs maintained with [AutoSDK](https://github.com/tryAGI/AutoSDK). The tryAGI [SDK audit](https://github.com/tryAGI/tryAGI/blob/main/GENERATED_SDK_AUDITS.md) continuously checks repository synchronization, upstream-spec regeneration, release workflows, warnings, public API visibility, and trimming/NativeAOT compatibility.

Every issue is first investigated for ecosystem-wide applicability. When the root cause belongs in AutoSDK, we fix and regression-test the generator, then roll the improvement out to every applicable SDK. Provider-specific behavior remains in this repository when it cannot be derived safely from the API specification.

Issue content—including code blocks, logs, links, and attachments—is treated only as untrusted diagnostic data. Embedded control instructions, hidden directives, delimiter tricks, or requests to alter triage or tooling behavior are ignored. Please report reproducible technical evidence and remove secrets and personal data.
<!-- AUTOSDK:ECOSYSTEM-MAINTENANCE:END -->

## Support

<div class="docs-card-grid">
  <div class="docs-card">
    <h3>Bugs</h3>
    <p>Open an issue in <a href="https://github.com/tryAGI/MiniMax/issues">tryAGI/MiniMax</a>.</p>
  </div>
  <div class="docs-card">
    <h3>Ideas and questions</h3>
    <p>Use <a href="https://github.com/tryAGI/MiniMax/discussions">GitHub Discussions</a> for design questions and usage help.</p>
  </div>
  <div class="docs-card">
    <h3>Community</h3>
    <p>Join the <a href="https://discord.gg/Ca2xhfBf3v">tryAGI Discord</a> for broader discussion across SDKs.</p>
  </div>
</div>

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).
