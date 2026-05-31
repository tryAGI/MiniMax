#nullable enable

namespace MiniMax
{
    public partial interface ISpeechClient
    {
        /// <summary>
        /// Synthesize speech.
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
        /// Synthesize speech.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MiniMax.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::MiniMax.AutoSDKHttpResponse<global::MiniMax.TextToSpeechResponse>> CreateTextToSpeechAsResponseAsync(

            global::MiniMax.TextToSpeechRequest request,
            global::MiniMax.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Synthesize speech.
        /// </summary>
        /// <param name="model">
        /// Speech model.
        /// </param>
        /// <param name="text">
        /// Input text.
        /// </param>
        /// <param name="stream">
        /// Default Value: false
        /// </param>
        /// <param name="streamOptions"></param>
        /// <param name="voiceSetting"></param>
        /// <param name="audioSetting"></param>
        /// <param name="pronunciationDict"></param>
        /// <param name="timbreWeights"></param>
        /// <param name="languageBoost"></param>
        /// <param name="voiceModify"></param>
        /// <param name="subtitleEnable">
        /// Default Value: false
        /// </param>
        /// <param name="subtitleType">
        /// Default Value: sentence
        /// </param>
        /// <param name="outputFormat">
        /// Default Value: hex
        /// </param>
        /// <param name="aigcWatermark">
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
            global::System.Collections.Generic.IList<global::MiniMax.TimberWeight>? timbreWeights = default,
            global::MiniMax.TextToSpeechRequestLanguageBoost? languageBoost = default,
            global::MiniMax.TtsVoiceModify? voiceModify = default,
            bool? subtitleEnable = default,
            global::MiniMax.TextToSpeechRequestSubtitleType? subtitleType = default,
            global::MiniMax.TextToSpeechRequestOutputFormat? outputFormat = default,
            bool? aigcWatermark = default,
            global::MiniMax.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}