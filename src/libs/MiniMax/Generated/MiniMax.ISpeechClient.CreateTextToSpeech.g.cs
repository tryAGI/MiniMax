#nullable enable

namespace MiniMax
{
    public partial interface ISpeechClient
    {
        /// <summary>
        /// Synthesize speech (T2A v2).<br/>
        /// Converts text to speech using MiniMax TTS models<br/>
        /// (`speech-2.8-hd`, `speech-2.8-turbo`, `speech-2.6-hd`,<br/>
        /// `speech-2.6-turbo`, `speech-02-hd`, `speech-02-turbo`). Supports up<br/>
        /// to 10,000 characters, 40 languages, and 7 emotional tones.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MiniMax.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::MiniMax.TextToSpeechResponse> CreateTextToSpeechAsync(

            global::MiniMax.TextToSpeechRequest request,
            global::MiniMax.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Synthesize speech (T2A v2).<br/>
        /// Converts text to speech using MiniMax TTS models<br/>
        /// (`speech-2.8-hd`, `speech-2.8-turbo`, `speech-2.6-hd`,<br/>
        /// `speech-2.6-turbo`, `speech-02-hd`, `speech-02-turbo`). Supports up<br/>
        /// to 10,000 characters, 40 languages, and 7 emotional tones.
        /// </summary>
        /// <param name="model">
        /// TTS model version: `speech-2.8-hd`, `speech-2.8-turbo`,<br/>
        /// `speech-2.6-hd`, `speech-2.6-turbo`, `speech-02-hd`,<br/>
        /// `speech-02-turbo`, `speech-01-hd`, `speech-01-turbo`.
        /// </param>
        /// <param name="text">
        /// Input text, up to 10,000 characters. Use `\n` for paragraph breaks.
        /// </param>
        /// <param name="stream">
        /// Whether to stream the output.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="streamOptions"></param>
        /// <param name="voiceSetting">
        /// Voice configuration for TTS.
        /// </param>
        /// <param name="audioSetting">
        /// Audio output configuration for TTS.
        /// </param>
        /// <param name="pronunciationDict">
        /// Custom pronunciation rules.
        /// </param>
        /// <param name="voiceModify">
        /// Voice effect/modulation settings.
        /// </param>
        /// <param name="timberWeights">
        /// Mix multiple voices by weight (up to 4 entries).
        /// </param>
        /// <param name="languageBoost">
        /// Bias pronunciation toward a specific language, or `auto` to<br/>
        /// auto-detect. Examples — `English`, `Chinese`, `Japanese`,<br/>
        /// `Korean`, `auto`.
        /// </param>
        /// <param name="outputFormat">
        /// Output format (non-streaming only).<br/>
        /// Default Value: hex
        /// </param>
        /// <param name="subtitleEnable">
        /// Whether to return subtitle files alongside the audio.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::MiniMax.TextToSpeechResponse> CreateTextToSpeechAsync(
            string model,
            string text,
            global::MiniMax.TtsVoiceSetting voiceSetting,
            bool? stream = default,
            global::MiniMax.TtsStreamOptions? streamOptions = default,
            global::MiniMax.TtsAudioSetting? audioSetting = default,
            global::MiniMax.TtsPronunciationDict? pronunciationDict = default,
            global::MiniMax.TtsVoiceModify? voiceModify = default,
            global::System.Collections.Generic.IList<global::MiniMax.TimberWeight>? timberWeights = default,
            string? languageBoost = default,
            global::MiniMax.TextToSpeechRequestOutputFormat? outputFormat = default,
            bool? subtitleEnable = default,
            global::MiniMax.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}