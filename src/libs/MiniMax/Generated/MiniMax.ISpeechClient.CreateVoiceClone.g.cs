#nullable enable

namespace MiniMax
{
    public partial interface ISpeechClient
    {
        /// <summary>
        /// Create a voice clone.<br/>
        /// Creates a custom voice clone from a previously uploaded reference<br/>
        /// audio file. First upload an MP3/M4A/WAV file (10s-5min, clear<br/>
        /// speech) via `POST /v1/files/upload` with `purpose=voice_clone`, then<br/>
        /// pass the returned `file_id` here.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MiniMax.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::MiniMax.VoiceCloneResponse> CreateVoiceCloneAsync(

            global::MiniMax.VoiceCloneRequest request,
            global::MiniMax.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a voice clone.<br/>
        /// Creates a custom voice clone from a previously uploaded reference<br/>
        /// audio file. First upload an MP3/M4A/WAV file (10s-5min, clear<br/>
        /// speech) via `POST /v1/files/upload` with `purpose=voice_clone`, then<br/>
        /// pass the returned `file_id` here.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MiniMax.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::MiniMax.AutoSDKHttpResponse<global::MiniMax.VoiceCloneResponse>> CreateVoiceCloneAsResponseAsync(

            global::MiniMax.VoiceCloneRequest request,
            global::MiniMax.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a voice clone.<br/>
        /// Creates a custom voice clone from a previously uploaded reference<br/>
        /// audio file. First upload an MP3/M4A/WAV file (10s-5min, clear<br/>
        /// speech) via `POST /v1/files/upload` with `purpose=voice_clone`, then<br/>
        /// pass the returned `file_id` here.
        /// </summary>
        /// <param name="fileId">
        /// File ID returned from `POST /v1/files/upload` with `purpose=voice_clone`.
        /// </param>
        /// <param name="voiceId">
        /// Custom voice ID to assign to the clone (8–256 characters,<br/>
        /// alphanumeric, starts with a letter).
        /// </param>
        /// <param name="needNoiseReduction">
        /// Whether to apply noise reduction to the reference audio.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="needVolumeNormalization">
        /// Whether to normalize the volume of the reference audio.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="text">
        /// Optional sample text to synthesize with the new voice to confirm cloning.
        /// </param>
        /// <param name="model">
        /// TTS model to use for the sample synthesis (e.g., `speech-2.6-hd`).
        /// </param>
        /// <param name="accuracy">
        /// Cloning accuracy threshold, 0.0–1.0.
        /// </param>
        /// <param name="clonePrompt">
        /// Reference prompt-audio pair used to refine the cloned voice.
        /// </param>
        /// <param name="aigcWatermark">
        /// Whether to embed an AIGC watermark on the generated sample audio.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::MiniMax.VoiceCloneResponse> CreateVoiceCloneAsync(
            string fileId,
            string voiceId,
            bool? needNoiseReduction = default,
            bool? needVolumeNormalization = default,
            string? text = default,
            string? model = default,
            float? accuracy = default,
            global::MiniMax.VoiceClonePrompt? clonePrompt = default,
            bool? aigcWatermark = default,
            global::MiniMax.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}