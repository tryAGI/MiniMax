using System.Net;
using System.Text;

namespace MiniMax.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task TextToSpeechStreaming_ReadsAudioEvents_WithoutProviderAccess()
    {
        string? requestBody = null;
        using var transport = new HttpClient(new StreamingHandler(async request =>
        {
            requestBody = await request.Content!.ReadAsStringAsync();
            Assert.AreEqual("text/event-stream", request.Headers.Accept.Single().MediaType);
            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent("data: {\"data\":{\"audio\":\"0102\",\"status\":1}}\n\ndata: {\"data\":{\"status\":2}}\n\n", Encoding.UTF8, "text/event-stream")
            };
        }));
        using var client = new MiniMaxClient("test-key", transport);
        var events = new List<TextToSpeechResponse>();
        await foreach (var item in client.Speech.CreateTextToSpeechAsStreamAsync(new TextToSpeechRequest
        {
            Model = "speech-02-hd",
            Text = "hello",
            VoiceSetting = new TtsVoiceSetting { VoiceId = "test-voice" }
        }))
        {
            events.Add(item);
        }

        Assert.AreEqual(2, events.Count);
        Assert.AreEqual("0102", events[0].Data?.Audio);
        Assert.AreEqual(2, events[1].Data?.Status);
        StringAssert.Contains(requestBody, "\"stream\":true");
    }

    private sealed class StreamingHandler(Func<HttpRequestMessage, Task<HttpResponseMessage>> respond) : HttpMessageHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
            => respond(request);
    }
}
