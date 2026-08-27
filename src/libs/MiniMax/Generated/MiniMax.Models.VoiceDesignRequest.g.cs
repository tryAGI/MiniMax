
#nullable enable

namespace MiniMax
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VoiceDesignRequest
    {
        /// <summary>
        /// Voice design instructions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Text synthesized for the preview sample.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview_text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PreviewText { get; set; }

        /// <summary>
        /// Optional custom voice ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        public string? VoiceId { get; set; }

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
        /// Initializes a new instance of the <see cref="VoiceDesignRequest" /> class.
        /// </summary>
        /// <param name="prompt">
        /// Voice design instructions.
        /// </param>
        /// <param name="previewText">
        /// Text synthesized for the preview sample.
        /// </param>
        /// <param name="voiceId">
        /// Optional custom voice ID.
        /// </param>
        /// <param name="aigcWatermark"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceDesignRequest(
            string prompt,
            string previewText,
            string? voiceId,
            bool? aigcWatermark)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.PreviewText = previewText ?? throw new global::System.ArgumentNullException(nameof(previewText));
            this.VoiceId = voiceId;
            this.AigcWatermark = aigcWatermark;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceDesignRequest" /> class.
        /// </summary>
        public VoiceDesignRequest()
        {
        }

    }
}