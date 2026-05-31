# MEAI AIFunction tools

Exposes MiniMax video, music, TTS, and voice-clone endpoints as MEAI
AIFunctions so they can be attached to any IChatClient.

This example assumes `using MiniMax;` is in scope and `apiKey` contains your MiniMax API key.

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