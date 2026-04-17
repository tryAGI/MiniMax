/*
order: 10
title: Create a video generation task
slug: create-video-task

Submits a Hailuo video generation task and returns the `task_id`.
*/

namespace MiniMax.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_CreateVideoTask()
    {
        using var client = GetAuthenticatedClient();

        var response = await client.Video.CreateVideoGenerationTaskAsync(
            model: "MiniMax-Hailuo-2.3",
            prompt: "A cinematic drone shot of a mountain range at sunrise, mist curling through the valleys.",
            duration: 6,
            resolution: VideoGenerationRequestResolution.x1080p);

        response.BaseResp?.StatusCode.Should().Be(0);
        response.TaskId.Should().NotBeNullOrWhiteSpace();

        Console.WriteLine($"task_id: {response.TaskId}");
    }
}
