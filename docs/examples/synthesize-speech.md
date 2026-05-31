# Synthesize speech (T2A v2)

Uses T2A v2 to synthesize speech from text and returns a downloadable URL.

This example assumes `using MiniMax;` is in scope and `apiKey` contains your MiniMax API key.

```csharp
using var client = new MiniMaxClient(apiKey);

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

Console.WriteLine($"audio: {response.Data?.Audio}");
Console.WriteLine($"length_ms: {response.ExtraInfo?.AudioLength}");
```