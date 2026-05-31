#nullable enable

namespace MiniMax
{
    public partial interface ISpeechClient
    {
        /// <summary>
        /// Create a voice clone.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MiniMax.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::MiniMax.VoiceCloneResponse> CreateVoiceCloneAsync(

            global::MiniMax.VoiceCloneRequest request,
            global::MiniMax.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a voice clone.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MiniMax.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::MiniMax.AutoSDKHttpResponse<global::MiniMax.VoiceCloneResponse>> CreateVoiceCloneAsResponseAsync(

            global::MiniMax.VoiceCloneRequest request,
            global::MiniMax.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a voice clone.
        /// </summary>
        /// <param name="fileId">
        /// Reference audio file ID from file upload.
        /// </param>
        /// <param name="voiceId">
        /// Target custom voice ID.
        /// </param>
        /// <param name="clonePrompt"></param>
        /// <param name="text">
        /// Optional sample text for verification synthesis.
        /// </param>
        /// <param name="model">
        /// Speech model for the optional verification sample.
        /// </param>
        /// <param name="languageBoost"></param>
        /// <param name="needNoiseReduction">
        /// Default Value: false
        /// </param>
        /// <param name="needVolumeNormalization">
        /// Default Value: false
        /// </param>
        /// <param name="aigcWatermark">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::MiniMax.VoiceCloneResponse> CreateVoiceCloneAsync(
            long fileId,
            string voiceId,
            global::MiniMax.VoiceClonePrompt? clonePrompt = default,
            string? text = default,
            string? model = default,
            global::MiniMax.VoiceCloneRequestLanguageBoost? languageBoost = default,
            bool? needNoiseReduction = default,
            bool? needVolumeNormalization = default,
            bool? aigcWatermark = default,
            global::MiniMax.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}