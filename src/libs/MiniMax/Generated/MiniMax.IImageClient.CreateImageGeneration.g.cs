#nullable enable

namespace MiniMax
{
    public partial interface IImageClient
    {
        /// <summary>
        /// Generate images.<br/>
        /// Creates images from text prompts and optionally from reference images using the same endpoint.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MiniMax.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::MiniMax.ImageGenerationResponse> CreateImageGenerationAsync(

            global::MiniMax.ImageGenerationRequest request,
            global::MiniMax.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate images.<br/>
        /// Creates images from text prompts and optionally from reference images using the same endpoint.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MiniMax.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::MiniMax.AutoSDKHttpResponse<global::MiniMax.ImageGenerationResponse>> CreateImageGenerationAsResponseAsync(

            global::MiniMax.ImageGenerationRequest request,
            global::MiniMax.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate images.<br/>
        /// Creates images from text prompts and optionally from reference images using the same endpoint.
        /// </summary>
        /// <param name="model">
        /// Image generation model.
        /// </param>
        /// <param name="prompt">
        /// Image prompt, up to 1500 characters.
        /// </param>
        /// <param name="subjectReference">
        /// Optional subject references for image-to-image generation.
        /// </param>
        /// <param name="style">
        /// Optional style configuration for `image-01-live`.
        /// </param>
        /// <param name="aspectRatio">
        /// Requested aspect ratio.
        /// </param>
        /// <param name="width">
        /// Output width in pixels for `image-01`.
        /// </param>
        /// <param name="height">
        /// Output height in pixels for `image-01`.
        /// </param>
        /// <param name="responseFormat">
        /// How images are returned.<br/>
        /// Default Value: url
        /// </param>
        /// <param name="seed"></param>
        /// <param name="n">
        /// Number of images to generate.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="promptOptimizer">
        /// Default Value: false
        /// </param>
        /// <param name="aigcWatermark"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::MiniMax.ImageGenerationResponse> CreateImageGenerationAsync(
            string model,
            string prompt,
            global::System.Collections.Generic.IList<global::MiniMax.ImageSubjectReference>? subjectReference = default,
            global::MiniMax.ImageStyle? style = default,
            global::MiniMax.ImageGenerationRequestAspectRatio? aspectRatio = default,
            int? width = default,
            int? height = default,
            global::MiniMax.ImageGenerationRequestResponseFormat? responseFormat = default,
            long? seed = default,
            int? n = default,
            bool? promptOptimizer = default,
            bool? aigcWatermark = default,
            global::MiniMax.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}