# Generate music

Generates an instrumental track with music-2.6 and returns a downloadable URL.

This example assumes `using MiniMax;` is in scope and `apiKey` contains your MiniMax API key.

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