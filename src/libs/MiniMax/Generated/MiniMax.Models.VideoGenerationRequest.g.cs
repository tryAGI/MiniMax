
#nullable enable

namespace MiniMax
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VideoGenerationRequest
    {
        /// <summary>
        /// Video generation model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Text prompt for text-to-video or guided image/video generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_optimizer")]
        public bool? PromptOptimizer { get; set; }

        /// <summary>
        /// Faster prompt preprocessing for supported models.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fast_pretreatment")]
        public bool? FastPretreatment { get; set; }

        /// <summary>
        /// First frame image URL or data URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_frame_image")]
        public string? FirstFrameImage { get; set; }

        /// <summary>
        /// Last frame image URL or data URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_frame_image")]
        public string? LastFrameImage { get; set; }

        /// <summary>
        /// Subject references for `S2V-01`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject_reference")]
        public global::System.Collections.Generic.IList<global::MiniMax.VideoSubjectReference>? SubjectReference { get; set; }

        /// <summary>
        /// Video duration in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// Requested output resolution.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MiniMax.JsonConverters.VideoGenerationRequestResolutionJsonConverter))]
        public global::MiniMax.VideoGenerationRequestResolution? Resolution { get; set; }

        /// <summary>
        /// Webhook URL for async task updates.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        ///
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
        /// Video generation model.
        /// </param>
        /// <param name="prompt">
        /// Text prompt for text-to-video or guided image/video generation.
        /// </param>
        /// <param name="promptOptimizer">
        /// Default Value: true
        /// </param>
        /// <param name="fastPretreatment">
        /// Faster prompt preprocessing for supported models.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="firstFrameImage">
        /// First frame image URL or data URL.
        /// </param>
        /// <param name="lastFrameImage">
        /// Last frame image URL or data URL.
        /// </param>
        /// <param name="subjectReference">
        /// Subject references for `S2V-01`.
        /// </param>
        /// <param name="duration">
        /// Video duration in seconds.
        /// </param>
        /// <param name="resolution">
        /// Requested output resolution.
        /// </param>
        /// <param name="callbackUrl">
        /// Webhook URL for async task updates.
        /// </param>
        /// <param name="aigcWatermark"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoGenerationRequest(
            string model,
            string? prompt,
            bool? promptOptimizer,
            bool? fastPretreatment,
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
            this.FastPretreatment = fastPretreatment;
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