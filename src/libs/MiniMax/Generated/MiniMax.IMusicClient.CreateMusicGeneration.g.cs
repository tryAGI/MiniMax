#nullable enable

namespace MiniMax
{
    public partial interface IMusicClient
    {
        /// <summary>
        /// Generate music.<br/>
        /// Generates music using MiniMax music models (`music-2.6`, `music-cover`,<br/>
        /// `music-2.6-free`, `music-cover-free`). The response contains either<br/>
        /// hex-encoded audio (`output_format=hex`, default) or a downloadable URL<br/>
        /// (`output_format=url`).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MiniMax.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::MiniMax.MusicGenerationResponse> CreateMusicGenerationAsync(

            global::MiniMax.MusicGenerationRequest request,
            global::MiniMax.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate music.<br/>
        /// Generates music using MiniMax music models (`music-2.6`, `music-cover`,<br/>
        /// `music-2.6-free`, `music-cover-free`). The response contains either<br/>
        /// hex-encoded audio (`output_format=hex`, default) or a downloadable URL<br/>
        /// (`output_format=url`).
        /// </summary>
        /// <param name="model">
        /// Music model. Supported values:<br/>
        /// `music-2.6`, `music-cover`, `music-2.6-free`, `music-cover-free`,<br/>
        /// `music-2.0`.
        /// </param>
        /// <param name="prompt">
        /// Music description (style, mood, scenario) — 1 to 2000 characters.
        /// </param>
        /// <param name="lyrics">
        /// Song lyrics with `\n` line breaks. Supports structure tags such as<br/>
        /// `[Verse]`, `[Chorus]`, `[Bridge]`. 1 to 3500 characters.
        /// </param>
        /// <param name="stream">
        /// Whether to stream the output (server-sent events).<br/>
        /// Default Value: false
        /// </param>
        /// <param name="outputFormat">
        /// Output format — `hex` returns hex-encoded bytes inline, `url` returns a downloadable link.<br/>
        /// Default Value: hex
        /// </param>
        /// <param name="audioSetting">
        /// Audio output configuration for music generation.
        /// </param>
        /// <param name="lyricsOptimizer">
        /// Whether to auto-generate lyrics from the prompt.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="isInstrumental">
        /// Whether to generate instrumental music (no vocals).<br/>
        /// Default Value: false
        /// </param>
        /// <param name="audioUrl">
        /// Reference audio URL for `music-cover` models.
        /// </param>
        /// <param name="audioBase64">
        /// Base64-encoded reference audio for `music-cover` models.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::MiniMax.MusicGenerationResponse> CreateMusicGenerationAsync(
            string model,
            string? prompt = default,
            string? lyrics = default,
            bool? stream = default,
            global::MiniMax.MusicGenerationRequestOutputFormat? outputFormat = default,
            global::MiniMax.MusicAudioSetting? audioSetting = default,
            bool? lyricsOptimizer = default,
            bool? isInstrumental = default,
            string? audioUrl = default,
            string? audioBase64 = default,
            global::MiniMax.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}