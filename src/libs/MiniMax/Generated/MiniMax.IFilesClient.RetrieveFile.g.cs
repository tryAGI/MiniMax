#nullable enable

namespace MiniMax
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Retrieve a file.<br/>
        /// Fetches metadata (including a temporary `download_url`) for a<br/>
        /// previously uploaded or generated file.
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MiniMax.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::MiniMax.FileRetrieveResponse> RetrieveFileAsync(
            string fileId,
            global::MiniMax.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}