
#nullable enable

namespace MiniMax
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoTemplateGenerationRequest
    {
        /// <summary>
        /// Video template ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TemplateId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_inputs")]
        public global::System.Collections.Generic.IList<global::MiniMax.VideoTemplateTextInput>? TextInputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_inputs")]
        public global::System.Collections.Generic.IList<global::MiniMax.VideoTemplateMediaInput>? MediaInputs { get; set; }

        /// <summary>
        /// Webhook URL for task updates.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoTemplateGenerationRequest" /> class.
        /// </summary>
        /// <param name="templateId">
        /// Video template ID.
        /// </param>
        /// <param name="textInputs"></param>
        /// <param name="mediaInputs"></param>
        /// <param name="callbackUrl">
        /// Webhook URL for task updates.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoTemplateGenerationRequest(
            string templateId,
            global::System.Collections.Generic.IList<global::MiniMax.VideoTemplateTextInput>? textInputs,
            global::System.Collections.Generic.IList<global::MiniMax.VideoTemplateMediaInput>? mediaInputs,
            string? callbackUrl)
        {
            this.TemplateId = templateId ?? throw new global::System.ArgumentNullException(nameof(templateId));
            this.TextInputs = textInputs;
            this.MediaInputs = mediaInputs;
            this.CallbackUrl = callbackUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoTemplateGenerationRequest" /> class.
        /// </summary>
        public VideoTemplateGenerationRequest()
        {
        }

    }
}