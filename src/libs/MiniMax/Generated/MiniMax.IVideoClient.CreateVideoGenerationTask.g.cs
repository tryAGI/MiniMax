#nullable enable

namespace MiniMax
{
    public partial interface IVideoClient
    {
        /// <summary>
        /// Create a video generation task.<br/>
        /// Creates an asynchronous video generation task using Hailuo video<br/>
        /// models. Returns a `task_id` that must be polled via<br/>
        /// `GET /v1/query/video_generation` until the task succeeds or fails.<br/>
        /// Once complete, the resulting file is retrieved via<br/>
        /// `GET /v1/files/retrieve`.
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
        /// Creates an asynchronous video generation task using Hailuo video<br/>
        /// models. Returns a `task_id` that must be polled via<br/>
        /// `GET /v1/query/video_generation` until the task succeeds or fails.<br/>
        /// Once complete, the resulting file is retrieved via<br/>
        /// `GET /v1/files/retrieve`.
        /// </summary>
        /// <param name="model">
        /// Model identifier. Popular choices:<br/>
        /// `MiniMax-Hailuo-2.3`, `MiniMax-Hailuo-2.3-Fast`,<br/>
        /// `MiniMax-Hailuo-02`, `T2V-01-Director`, `I2V-01-Director`,<br/>
        /// `S2V-01`.
        /// </param>
        /// <param name="prompt">
        /// Natural-language description of the desired video motion and content.
        /// </param>
        /// <param name="promptOptimizer">
        /// Whether to auto-optimize the prompt for better results.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="firstFrameImage">
        /// Starting frame image URL or data URI (image-to-video and start-end modes).
        /// </param>
        /// <param name="lastFrameImage">
        /// Ending frame image URL or data URI (start-end mode only).
        /// </param>
        /// <param name="subjectReference">
        /// Subject references for subject-reference generation (S2V).
        /// </param>
        /// <param name="duration">
        /// Video length in seconds (typically 6 or 10 depending on model).
        /// </param>
        /// <param name="resolution">
        /// Output resolution.
        /// </param>
        /// <param name="callbackUrl">
        /// Optional webhook URL invoked when the task completes.
        /// </param>
        /// <param name="aigcWatermark">
        /// Whether to embed an AIGC watermark in the output.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::MiniMax.VideoGenerationResponse> CreateVideoGenerationTaskAsync(
            string model,
            string? prompt = default,
            bool? promptOptimizer = default,
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