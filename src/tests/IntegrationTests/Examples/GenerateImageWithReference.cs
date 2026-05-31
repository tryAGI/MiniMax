/*
order: 16
title: Generate images from a reference image
slug: generate-image-reference

Uses the same image endpoint with `subject_reference` to perform image-to-image generation.
*/

namespace MiniMax.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_GenerateImageWithReference()
    {
        using var client = GetAuthenticatedClient();

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

        response.BaseResp?.StatusCode.Should().Be(0);
        response.Data?.ImageUrls.Should().NotBeNullOrEmpty();

        Console.WriteLine($"image_url: {response.Data?.ImageUrls?.FirstOrDefault()}");
    }
}
