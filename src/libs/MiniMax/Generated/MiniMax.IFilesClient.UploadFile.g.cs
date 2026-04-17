#nullable enable

namespace MiniMax
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Upload a file.<br/>
        /// Uploads a file (audio, image, or video) for subsequent use in<br/>
        /// voice-clone, music-cover, or video-generation workflows. Returns a<br/>
        /// `file_id` that can be referenced in other endpoints.
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
        /// Upload a file.<br/>
        /// Uploads a file (audio, image, or video) for subsequent use in<br/>
        /// voice-clone, music-cover, or video-generation workflows. Returns a<br/>
        /// `file_id` that can be referenced in other endpoints.
        /// </summary>
        /// <param name="purpose">
        /// File purpose — `voice_clone`, `prompt_audio`, `retrieval`,<br/>
        /// `fine-tune`, `fine-tune-results`.
        /// </param>
        /// <param name="file">
        /// The file to upload (MP3, M4A, WAV, image, video, etc.).
        /// </param>
        /// <param name="filename">
        /// The file to upload (MP3, M4A, WAV, image, video, etc.).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::MiniMax.FileUploadResponse> UploadFileAsync(
            string purpose,
            byte[] file,
            string filename,
            global::MiniMax.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}