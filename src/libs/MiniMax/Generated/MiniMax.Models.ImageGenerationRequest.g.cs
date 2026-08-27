
#nullable enable

namespace MiniMax
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ImageGenerationRequest
    {
        /// <summary>
        /// Image generation model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Image prompt, up to 1500 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Optional subject references for image-to-image generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject_reference")]
        public global::System.Collections.Generic.IList<global::MiniMax.ImageSubjectReference>? SubjectReference { get; set; }

        /// <summary>
        /// Optional style configuration for `image-01-live`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style")]
        public global::MiniMax.ImageStyle? Style { get; set; }

        /// <summary>
        /// Requested aspect ratio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MiniMax.JsonConverters.ImageGenerationRequestAspectRatioJsonConverter))]
        public global::MiniMax.ImageGenerationRequestAspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// Output width in pixels for `image-01`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        public int? Width { get; set; }

        /// <summary>
        /// Output height in pixels for `image-01`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        public int? Height { get; set; }

        /// <summary>
        /// How images are returned.<br/>
        /// Default Value: url
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MiniMax.JsonConverters.ImageGenerationRequestResponseFormatJsonConverter))]
        public global::MiniMax.ImageGenerationRequestResponseFormat? ResponseFormat { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public long? Seed { get; set; }

        /// <summary>
        /// Number of images to generate.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("n")]
        public int? N { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_optimizer")]
        public bool? PromptOptimizer { get; set; }

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
        /// Initializes a new instance of the <see cref="ImageGenerationRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// Image generation model.
        /// </param>
        /// <param name="prompt">
        /// Image prompt, up to 1500 characters.
        /// </param>
        /// <param name="subjectReference">
        /// Optional subject references for image-to-image generation.
        /// </param>
        /// <param name="style">
        /// Optional style configuration for `image-01-live`.
        /// </param>
        /// <param name="aspectRatio">
        /// Requested aspect ratio.
        /// </param>
        /// <param name="width">
        /// Output width in pixels for `image-01`.
        /// </param>
        /// <param name="height">
        /// Output height in pixels for `image-01`.
        /// </param>
        /// <param name="responseFormat">
        /// How images are returned.<br/>
        /// Default Value: url
        /// </param>
        /// <param name="seed"></param>
        /// <param name="n">
        /// Number of images to generate.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="promptOptimizer">
        /// Default Value: false
        /// </param>
        /// <param name="aigcWatermark"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageGenerationRequest(
            string model,
            string prompt,
            global::System.Collections.Generic.IList<global::MiniMax.ImageSubjectReference>? subjectReference,
            global::MiniMax.ImageStyle? style,
            global::MiniMax.ImageGenerationRequestAspectRatio? aspectRatio,
            int? width,
            int? height,
            global::MiniMax.ImageGenerationRequestResponseFormat? responseFormat,
            long? seed,
            int? n,
            bool? promptOptimizer,
            bool? aigcWatermark)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.SubjectReference = subjectReference;
            this.Style = style;
            this.AspectRatio = aspectRatio;
            this.Width = width;
            this.Height = height;
            this.ResponseFormat = responseFormat;
            this.Seed = seed;
            this.N = n;
            this.PromptOptimizer = promptOptimizer;
            this.AigcWatermark = aigcWatermark;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationRequest" /> class.
        /// </summary>
        public ImageGenerationRequest()
        {
        }

    }
}