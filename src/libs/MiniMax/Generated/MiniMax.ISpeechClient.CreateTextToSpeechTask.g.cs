#nullable enable

namespace MiniMax
{
    public partial interface ISpeechClient
    {
        /// <summary>
        /// Create an async speech synthesis task.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MiniMax.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::MiniMax.AsyncTextToSpeechTaskResponse> CreateTextToSpeechTaskAsync(

            global::MiniMax.AsyncTextToSpeechRequest request,
            global::MiniMax.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an async speech synthesis task.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MiniMax.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::MiniMax.AutoSDKHttpResponse<global::MiniMax.AsyncTextToSpeechTaskResponse>> CreateTextToSpeechTaskAsResponseAsync(

            global::MiniMax.AsyncTextToSpeechRequest request,
            global::MiniMax.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an async speech synthesis task.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="text">
        /// Inline text input.
        /// </param>
        /// <param name="textFileId">
        /// Uploaded text or zip file ID.
        /// </param>
        /// <param name="voiceSetting"></param>
        /// <param name="audioSetting"></param>
        /// <param name="pronunciationDict"></param>
        /// <param name="languageBoost"></param>
        /// <param name="voiceModify"></param>
        /// <param name="aigcWatermark">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::MiniMax.AsyncTextToSpeechTaskResponse> CreateTextToSpeechTaskAsync(
            string model,
            global::MiniMax.AsyncTextToSpeechVoiceSetting voiceSetting,
            string? text = default,
            long? textFileId = default,
            global::MiniMax.AsyncTextToSpeechAudioSetting? audioSetting = default,
            global::MiniMax.AsyncTextToSpeechPronunciationDict? pronunciationDict = default,
            global::MiniMax.AsyncTextToSpeechRequestLanguageBoost? languageBoost = default,
            global::MiniMax.TtsVoiceModify? voiceModify = default,
            bool? aigcWatermark = default,
            global::MiniMax.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}