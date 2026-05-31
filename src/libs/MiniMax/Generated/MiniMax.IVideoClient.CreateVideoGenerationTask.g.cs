#nullable enable

namespace MiniMax
{
    public partial interface IVideoClient
    {
        /// <summary>
        /// Create a video generation task.<br/>
        /// Creates an asynchronous Hailuo video generation task for text-to-video, image-to-video, start-end, or subject-reference modes.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MiniMax.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::MiniMax.VideoGenerationResponse> CreateVideoGenerationTaskAsync(

            global::MiniMax.VideoGenerationRequest request,
            global::MiniMax.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a video generation task.<br/>
        /// Creates an asynchronous Hailuo video generation task for text-to-video, image-to-video, start-end, or subject-reference modes.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MiniMax.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::MiniMax.AutoSDKHttpResponse<global::MiniMax.VideoGenerationResponse>> CreateVideoGenerationTaskAsResponseAsync(

            global::MiniMax.VideoGenerationRequest request,
            global::MiniMax.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a video generation task.<br/>
        /// Creates an asynchronous Hailuo video generation task for text-to-video, image-to-video, start-end, or subject-reference modes.
        /// </summary>
        /// <param name="model">
        /// Video generation model.
        /// </param>
        /// <param name="prompt">
        /// Text prompt for text-to-video or guided image/video generation.
        /// </param>
        /// <param name="promptOptimizer">
        /// Default Value: true
        /// </param>
        /// <param name="fastPretreatment">
        /// Faster prompt preprocessing for supported models.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="firstFrameImage">
        /// First frame image URL or data URL.
        /// </param>
        /// <param name="lastFrameImage">
        /// Last frame image URL or data URL.
        /// </param>
        /// <param name="subjectReference">
        /// Subject references for `S2V-01`.
        /// </param>
        /// <param name="duration">
        /// Video duration in seconds.
        /// </param>
        /// <param name="resolution">
        /// Requested output resolution.
        /// </param>
        /// <param name="callbackUrl">
        /// Webhook URL for async task updates.
        /// </param>
        /// <param name="aigcWatermark"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::MiniMax.VideoGenerationResponse> CreateVideoGenerationTaskAsync(
            string model,
            string? prompt = default,
            bool? promptOptimizer = default,
            bool? fastPretreatment = default,
            string? firstFrameImage = default,
            string? lastFrameImage = default,
            global::System.Collections.Generic.IList<global::MiniMax.VideoSubjectReference>? subjectReference = default,
            int? duration = default,
            global::MiniMax.VideoGenerationRequestResolution? resolution = default,
            string? callbackUrl = default,
            bool? aigcWatermark = default,
            global::MiniMax.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}