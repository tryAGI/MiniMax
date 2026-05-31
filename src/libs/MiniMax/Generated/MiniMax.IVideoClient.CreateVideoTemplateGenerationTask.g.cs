#nullable enable

namespace MiniMax
{
    public partial interface IVideoClient
    {
        /// <summary>
        /// Create a video template task.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MiniMax.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::MiniMax.VideoTemplateGenerationResponse> CreateVideoTemplateGenerationTaskAsync(

            global::MiniMax.VideoTemplateGenerationRequest request,
            global::MiniMax.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a video template task.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MiniMax.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::MiniMax.AutoSDKHttpResponse<global::MiniMax.VideoTemplateGenerationResponse>> CreateVideoTemplateGenerationTaskAsResponseAsync(

            global::MiniMax.VideoTemplateGenerationRequest request,
            global::MiniMax.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a video template task.
        /// </summary>
        /// <param name="templateId">
        /// Video template ID.
        /// </param>
        /// <param name="textInputs"></param>
        /// <param name="mediaInputs"></param>
        /// <param name="callbackUrl">
        /// Webhook URL for task updates.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::MiniMax.VideoTemplateGenerationResponse> CreateVideoTemplateGenerationTaskAsync(
            string templateId,
            global::System.Collections.Generic.IList<global::MiniMax.VideoTemplateTextInput>? textInputs = default,
            global::System.Collections.Generic.IList<global::MiniMax.VideoTemplateMediaInput>? mediaInputs = default,
            string? callbackUrl = default,
            global::MiniMax.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}