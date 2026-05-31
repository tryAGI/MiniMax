# Create a video generation task

Submits a Hailuo video generation task and returns the `task_id`.

This example assumes `using MiniMax;` is in scope and `apiKey` contains your MiniMax API key.

```csharp
using var client = new MiniMaxClient(apiKey);

var response = await client.Video.CreateVideoGenerationTaskAsync(
    model: "MiniMax-Hailuo-2.3",
    prompt: "A cinematic drone shot of a mountain range at sunrise, mist curling through the valleys.",
    duration: 6,
    resolution: VideoGenerationRequestResolution.x1080p);

Console.WriteLine($"task_id: {response.TaskId}");
```