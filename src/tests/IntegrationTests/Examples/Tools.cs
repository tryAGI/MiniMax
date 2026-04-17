/*
order: 40
title: MEAI AIFunction tools
slug: meai-tools

Exposes MiniMax video, music, TTS, and voice-clone endpoints as MEAI
AIFunctions so they can be attached to any IChatClient.
*/

using Microsoft.Extensions.AI;

namespace MiniMax.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void Example_BuildTools()
    {
        using var client = GetAuthenticatedClient();

        AIFunction[] tools =
        [
            client.AsCreateVideoTaskTool(),
            client.AsGetVideoTaskTool(),
            client.AsGenerateMusicTool(),
            client.AsSynthesizeSpeechTool(),
            client.AsCloneVoiceTool(),
        ];

        tools.Should().HaveCount(5);
        tools.Select(t => t.Name).Should().BeEquivalentTo(
            "CreateVideoTask",
            "GetVideoTask",
            "GenerateMusic",
            "SynthesizeSpeech",
            "CloneVoice");
    }
}
