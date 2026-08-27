
#nullable enable

namespace MiniMax
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VoiceCloneRequest
    {
        /// <summary>
        /// Reference audio file ID from file upload.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long FileId { get; set; }

        /// <summary>
        /// Target custom voice ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VoiceId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clone_prompt")]
        public global::MiniMax.VoiceClonePrompt? ClonePrompt { get; set; }

        /// <summary>
        /// Optional sample text for verification synthesis.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Speech model for the optional verification sample.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_boost")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MiniMax.JsonConverters.VoiceCloneRequestLanguageBoostJsonConverter))]
        public global::MiniMax.VoiceCloneRequestLanguageBoost? LanguageBoost { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("need_noise_reduction")]
        public bool? NeedNoiseReduction { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("need_volume_normalization")]
        public bool? NeedVolumeNormalization { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aigc_watermark")]
        public bool? AigcWatermark { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceCloneRequest" /> class.
        /// </summary>
        /// <param name="fileId">
        /// Reference audio file ID from file upload.
        /// </param>
        /// <param name="voiceId">
        /// Target custom voice ID.
        /// </param>
        /// <param name="clonePrompt"></param>
        /// <param name="text">
        /// Optional sample text for verification synthesis.
        /// </param>
        /// <param name="model">
        /// Speech model for the optional verification sample.
        /// </param>
        /// <param name="languageBoost"></param>
        /// <param name="needNoiseReduction">
        /// Default Value: false
        /// </param>
        /// <param name="needVolumeNormalization">
        /// Default Value: false
        /// </param>
        /// <param name="aigcWatermark">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceCloneRequest(
            long fileId,
            string voiceId,
            global::MiniMax.VoiceClonePrompt? clonePrompt,
            string? text,
            string? model,
            global::MiniMax.VoiceCloneRequestLanguageBoost? languageBoost,
            bool? needNoiseReduction,
            bool? needVolumeNormalization,
            bool? aigcWatermark)
        {
            this.FileId = fileId;
            this.VoiceId = voiceId ?? throw new global::System.ArgumentNullException(nameof(voiceId));
            this.ClonePrompt = clonePrompt;
            this.Text = text;
            this.Model = model;
            this.LanguageBoost = languageBoost;
            this.NeedNoiseReduction = needNoiseReduction;
            this.NeedVolumeNormalization = needVolumeNormalization;
            this.AigcWatermark = aigcWatermark;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceCloneRequest" /> class.
        /// </summary>
        public VoiceCloneRequest()
        {
        }

    }
}