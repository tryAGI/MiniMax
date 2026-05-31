#nullable enable

namespace MiniMax
{
    public partial interface IMusicClient
    {
        /// <summary>
        /// Generate or continue lyrics.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MiniMax.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::MiniMax.LyricsGenerationResponse> CreateLyricsGenerationAsync(

            global::MiniMax.LyricsGenerationRequest request,
            global::MiniMax.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate or continue lyrics.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MiniMax.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::MiniMax.AutoSDKHttpResponse<global::MiniMax.LyricsGenerationResponse>> CreateLyricsGenerationAsResponseAsync(

            global::MiniMax.LyricsGenerationRequest request,
            global::MiniMax.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate or continue lyrics.
        /// </summary>
        /// <param name="mode">
        /// Lyrics generation mode.
        /// </param>
        /// <param name="prompt">
        /// Prompt describing the song or rewrite request.
        /// </param>
        /// <param name="lyrics">
        /// Existing lyrics for continuation or rewrite.
        /// </param>
        /// <param name="title">
        /// Optional title hint.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::MiniMax.LyricsGenerationResponse> CreateLyricsGenerationAsync(
            global::MiniMax.LyricsGenerationRequestMode mode,
            string? prompt = default,
            string? lyrics = default,
            string? title = default,
            global::MiniMax.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}