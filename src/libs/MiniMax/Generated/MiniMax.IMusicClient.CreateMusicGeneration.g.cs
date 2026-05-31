#nullable enable

namespace MiniMax
{
    public partial interface IMusicClient
    {
        /// <summary>
        /// Generate music.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MiniMax.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::MiniMax.MusicGenerationResponse> CreateMusicGenerationAsync(

            global::MiniMax.MusicGenerationRequest request,
            global::MiniMax.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate music.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MiniMax.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::MiniMax.AutoSDKHttpResponse<global::MiniMax.MusicGenerationResponse>> CreateMusicGenerationAsResponseAsync(

            global::MiniMax.MusicGenerationRequest request,
            global::MiniMax.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate music.
        /// </summary>
        /// <param name="model">
        /// Music generation model.
        /// </param>
        /// <param name="prompt">
        /// Music prompt.
        /// </param>
        /// <param name="lyrics">
        /// Lyrics with optional section markers.
        /// </param>
        /// <param name="stream">
        /// Default Value: false
        /// </param>
        /// <param name="outputFormat">
        /// Default Value: hex
        /// </param>
        /// <param name="audioSetting"></param>
        /// <param name="aigcWatermark"></param>
        /// <param name="lyricsOptimizer">
        /// Default Value: false
        /// </param>
        /// <param name="isInstrumental">
        /// Default Value: false
        /// </param>
        /// <param name="audioUrl">
        /// Reference audio URL for cover generation.
        /// </param>
        /// <param name="audioBase64">
        /// Reference audio as base64 for cover generation.
        /// </param>
        /// <param name="coverFeatureId">
        /// Preprocessed cover feature ID for two-step cover generation.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::MiniMax.MusicGenerationResponse> CreateMusicGenerationAsync(
            string model,
            string? prompt = default,
            string? lyrics = default,
            bool? stream = default,
            global::MiniMax.MusicGenerationRequestOutputFormat? outputFormat = default,
            global::MiniMax.MusicAudioSetting? audioSetting = default,
            bool? aigcWatermark = default,
            bool? lyricsOptimizer = default,
            bool? isInstrumental = default,
            string? audioUrl = default,
            string? audioBase64 = default,
            string? coverFeatureId = default,
            global::MiniMax.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}