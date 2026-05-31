/*
order: 15
title: Generate images from text
slug: generate-image

Generates one or more images with MiniMax's shared image endpoint and returns image URLs.
*/

namespace MiniMax.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_GenerateImage()
    {
        using var client = GetAuthenticatedClient();

        var response = await client.Image.CreateImageGenerationAsync(
            model: "image-01",
            prompt: "A clean product photo of a matte black mechanical keyboard on a walnut desk, soft studio lighting, photorealistic.",
            aspectRatio: ImageGenerationRequestAspectRatio.x16_9,
            responseFormat: ImageGenerationRequestResponseFormat.Url,
            n: 1,
            promptOptimizer: true);

        response.BaseResp?.StatusCode.Should().Be(0);
        response.Data?.ImageUrls.Should().NotBeNullOrEmpty();

        Console.WriteLine($"image_url: {response.Data?.ImageUrls?.FirstOrDefault()}");
    }
}
