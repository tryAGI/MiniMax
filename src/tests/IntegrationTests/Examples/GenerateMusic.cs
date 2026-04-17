/*
order: 30
title: Generate music
slug: generate-music

Generates an instrumental track with music-2.6 and returns a downloadable URL.
*/

namespace MiniMax.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_GenerateMusic()
    {
        using var client = GetAuthenticatedClient();

        var response = await client.Music.CreateMusicGenerationAsync(
            model: "music-2.6",
            prompt: "Upbeat electronic track with driving drums and shimmering synths, 120 bpm, hopeful mood.",
            isInstrumental: true,
            outputFormat: MusicGenerationRequestOutputFormat.Url);

        response.BaseResp?.StatusCode.Should().Be(0);
        response.Data?.Audio.Should().NotBeNullOrWhiteSpace();

        Console.WriteLine($"audio: {response.Data?.Audio}");
        Console.WriteLine($"duration_ms: {response.ExtraInfo?.MusicDuration}");
    }
}
