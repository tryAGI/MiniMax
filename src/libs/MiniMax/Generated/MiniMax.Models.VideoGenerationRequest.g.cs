
#nullable enable

namespace MiniMax
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoGenerationRequest
    {
        /// <summary>
        /// Model identifier. Popular choices:<br/>
        /// `MiniMax-Hailuo-2.3`, `MiniMax-Hailuo-2.3-Fast`,<br/>
        /// `MiniMax-Hailuo-02`, `T2V-01-Director`, `I2V-01-Director`,<br/>
        /// `S2V-01`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Natural-language description of the desired video motion and content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Whether to auto-optimize the prompt for better results.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_optimizer")]
        public bool? PromptOptimizer { get; set; }

        /// <summary>
        /// Starting frame image URL or data URI (image-to-video and start-end modes).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_frame_image")]
        public string? FirstFrameImage { get; set; }

        /// <summary>
        /// Ending frame image URL or data URI (start-end mode only).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_frame_image")]
        public string? LastFrameImage { get; set; }

        /// <summary>
        /// Subject references for subject-reference generation (S2V).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject_reference")]
        public global::System.Collections.Generic.IList<global::MiniMax.VideoSubjectReference>? SubjectReference { get; set; }

        /// <summary>
        /// Video length in seconds (typically 6 or 10 depending on model).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// Output resolution.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MiniMax.JsonConverters.VideoGenerationRequestResolutionJsonConverter))]
        public global::MiniMax.VideoGenerationRequestResolution? Resolution { get; set; }

        /// <summary>
        /// Optional webhook URL invoked when the task completes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// Whether to embed an AIGC watermark in the output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aigc_watermark")]
        public bool? AigcWatermark { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoGenerationRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// Model identifier. Popular choices:<br/>
        /// `MiniMax-Hailuo-2.3`, `MiniMax-Hailuo-2.3-Fast`,<br/>
        /// `MiniMax-Hailuo-02`, `T2V-01-Director`, `I2V-01-Director`,<br/>
        /// `S2V-01`.
        /// </param>
        /// <param name="prompt">
        /// Natural-language description of the desired video motion and content.
        /// </param>
        /// <param name="promptOptimizer">
        /// Whether to auto-optimize the prompt for better results.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="firstFrameImage">
        /// Starting frame image URL or data URI (image-to-video and start-end modes).
        /// </param>
        /// <param name="lastFrameImage">
        /// Ending frame image URL or data URI (start-end mode only).
        /// </param>
        /// <param name="subjectReference">
        /// Subject references for subject-reference generation (S2V).
        /// </param>
        /// <param name="duration">
        /// Video length in seconds (typically 6 or 10 depending on model).
        /// </param>
        /// <param name="resolution">
        /// Output resolution.
        /// </param>
        /// <param name="callbackUrl">
        /// Optional webhook URL invoked when the task completes.
        /// </param>
        /// <param name="aigcWatermark">
        /// Whether to embed an AIGC watermark in the output.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoGenerationRequest(
            string model,
            string? prompt,
            bool? promptOptimizer,
            string? firstFrameImage,
            string? lastFrameImage,
            global::System.Collections.Generic.IList<global::MiniMax.VideoSubjectReference>? subjectReference,
            int? duration,
            global::MiniMax.VideoGenerationRequestResolution? resolution,
            string? callbackUrl,
            bool? aigcWatermark)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Prompt = prompt;
            this.PromptOptimizer = promptOptimizer;
            this.FirstFrameImage = firstFrameImage;
            this.LastFrameImage = lastFrameImage;
            this.SubjectReference = subjectReference;
            this.Duration = duration;
            this.Resolution = resolution;
            this.CallbackUrl = callbackUrl;
            this.AigcWatermark = aigcWatermark;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoGenerationRequest" /> class.
        /// </summary>
        public VideoGenerationRequest()
        {
        }
    }
}