#nullable enable

namespace MiniMax
{
    public partial interface IMusicClient
    {
        /// <summary>
        /// Preprocess music-cover input audio.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MiniMax.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::MiniMax.MusicCoverPreprocessResponse> CreateMusicCoverPreprocessAsync(

            global::MiniMax.MusicCoverPreprocessRequest request,
            global::MiniMax.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Preprocess music-cover input audio.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MiniMax.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::MiniMax.AutoSDKHttpResponse<global::MiniMax.MusicCoverPreprocessResponse>> CreateMusicCoverPreprocessAsResponseAsync(

            global::MiniMax.MusicCoverPreprocessRequest request,
            global::MiniMax.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Preprocess music-cover input audio.
        /// </summary>
        /// <param name="model">
        /// Currently required to be `music-cover`.
        /// </param>
        /// <param name="audioUrl"></param>
        /// <param name="audioBase64"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::MiniMax.MusicCoverPreprocessResponse> CreateMusicCoverPreprocessAsync(
            string model,
            string? audioUrl = default,
            string? audioBase64 = default,
            global::MiniMax.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}