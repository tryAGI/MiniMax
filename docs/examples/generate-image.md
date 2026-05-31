# Generate images from text

Generates one or more images with MiniMax's shared image endpoint and returns image URLs.

This example assumes `using MiniMax;` is in scope and `apiKey` contains your MiniMax API key.

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