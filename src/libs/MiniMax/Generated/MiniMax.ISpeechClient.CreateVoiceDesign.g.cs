#nullable enable

namespace MiniMax
{
    public partial interface ISpeechClient
    {
        /// <summary>
        /// Generate a new voice from text instructions.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MiniMax.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::MiniMax.VoiceDesignResponse> CreateVoiceDesignAsync(

            global::MiniMax.VoiceDesignRequest request,
            global::MiniMax.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate a new voice from text instructions.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MiniMax.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::MiniMax.AutoSDKHttpResponse<global::MiniMax.VoiceDesignResponse>> CreateVoiceDesignAsResponseAsync(

            global::MiniMax.VoiceDesignRequest request,
            global::MiniMax.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate a new voice from text instructions.
        /// </summary>
        /// <param name="prompt">
        /// Voice design instructions.
        /// </param>
        /// <param name="previewText">
        /// Text synthesized for the preview sample.
        /// </param>
        /// <param name="voiceId">
        /// Optional custom voice ID.
        /// </param>
        /// <param name="aigcWatermark"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::MiniMax.VoiceDesignResponse> CreateVoiceDesignAsync(
            string prompt,
            string previewText,
            string? voiceId = default,
            bool? aigcWatermark = default,
            global::MiniMax.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}