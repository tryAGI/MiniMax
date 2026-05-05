#nullable enable

namespace MiniMax
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Delete a file.<br/>
        /// Deletes a previously uploaded file.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MiniMax.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::MiniMax.FileDeleteResponse> DeleteFileAsync(

            global::MiniMax.FileDeleteRequest request,
            global::MiniMax.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a file.<br/>
        /// Deletes a previously uploaded file.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MiniMax.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::MiniMax.AutoSDKHttpResponse<global::MiniMax.FileDeleteResponse>> DeleteFileAsResponseAsync(

            global::MiniMax.FileDeleteRequest request,
            global::MiniMax.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a file.<br/>
        /// Deletes a previously uploaded file.
        /// </summary>
        /// <param name="fileId">
        /// File ID to delete.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::MiniMax.FileDeleteResponse> DeleteFileAsync(
            long fileId,
            global::MiniMax.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}