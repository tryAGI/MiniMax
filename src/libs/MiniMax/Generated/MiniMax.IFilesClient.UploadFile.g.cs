#nullable enable

namespace MiniMax
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Upload a file.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MiniMax.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::MiniMax.FileUploadResponse> UploadFileAsync(

            global::MiniMax.FileUploadRequest request,
            global::MiniMax.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload a file.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MiniMax.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::MiniMax.AutoSDKHttpResponse<global::MiniMax.FileUploadResponse>> UploadFileAsResponseAsync(

            global::MiniMax.FileUploadRequest request,
            global::MiniMax.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload a file.
        /// </summary>
        /// <param name="purpose">
        /// Upload purpose.
        /// </param>
        /// <param name="file">
        /// File to upload.
        /// </param>
        /// <param name="filename">
        /// File to upload.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::MiniMax.FileUploadResponse> UploadFileAsync(
            global::MiniMax.FileUploadRequestPurpose purpose,
            byte[] file,
            string filename,
            global::MiniMax.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Upload a file.
        /// </summary>
        /// <param name="purpose">
        /// Upload purpose.
        /// </param>
        /// <param name="file">
        /// File to upload.
        /// </param>
        /// <param name="filename">
        /// File to upload.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MiniMax.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::MiniMax.FileUploadResponse> UploadFileAsync(
            global::MiniMax.FileUploadRequestPurpose purpose,
            global::System.IO.Stream file,
            string filename,
            global::MiniMax.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload a file.
        /// </summary>
        /// <param name="purpose">
        /// Upload purpose.
        /// </param>
        /// <param name="file">
        /// File to upload.
        /// </param>
        /// <param name="filename">
        /// File to upload.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MiniMax.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::MiniMax.AutoSDKHttpResponse<global::MiniMax.FileUploadResponse>> UploadFileAsResponseAsync(
            global::MiniMax.FileUploadRequestPurpose purpose,
            global::System.IO.Stream file,
            string filename,
            global::MiniMax.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}