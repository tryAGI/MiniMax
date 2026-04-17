/*
order: 20
title: Synthesize speech (T2A v2)
slug: synthesize-speech

Uses T2A v2 to synthesize speech from text and returns a downloadable URL.
*/

namespace MiniMax.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_SynthesizeSpeech()
    {
        using var client = GetAuthenticatedClient();

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

        response.BaseResp?.StatusCode.Should().Be(0);
        response.Data?.Audio.Should().NotBeNullOrWhiteSpace();

        Console.WriteLine($"audio: {response.Data?.Audio}");
        Console.WriteLine($"length_ms: {response.ExtraInfo?.AudioLength}");
    }
}
