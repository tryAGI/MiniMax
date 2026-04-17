
#nullable enable

namespace MiniMax
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoiceCloneRequest
    {
        /// <summary>
        /// File ID returned from `POST /v1/files/upload` with `purpose=voice_clone`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileId { get; set; }

        /// <summary>
        /// Custom voice ID to assign to the clone (8–256 characters,<br/>
        /// alphanumeric, starts with a letter).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VoiceId { get; set; }

        /// <summary>
        /// Whether to apply noise reduction to the reference audio.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("need_noise_reduction")]
        public bool? NeedNoiseReduction { get; set; }

        /// <summary>
        /// Whether to normalize the volume of the reference audio.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("need_volume_normalization")]
        public bool? NeedVolumeNormalization { get; set; }

        /// <summary>
        /// Optional sample text to synthesize with the new voice to confirm cloning.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// TTS model to use for the sample synthesis (e.g., `speech-2.6-hd`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Cloning accuracy threshold, 0.0–1.0.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accuracy")]
        public float? Accuracy { get; set; }

        /// <summary>
        /// Reference prompt-audio pair used to refine the cloned voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clone_prompt")]
        public global::MiniMax.VoiceClonePrompt? ClonePrompt { get; set; }

        /// <summary>
        /// Whether to embed an AIGC watermark on the generated sample audio.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceCloneRequest(
            string fileId,
            string voiceId,
            bool? needNoiseReduction,
            bool? needVolumeNormalization,
            string? text,
            string? model,
            float? accuracy,
            global::MiniMax.VoiceClonePrompt? clonePrompt,
            bool? aigcWatermark)
        {
            this.FileId = fileId ?? throw new global::System.ArgumentNullException(nameof(fileId));
            this.VoiceId = voiceId ?? throw new global::System.ArgumentNullException(nameof(voiceId));
            this.NeedNoiseReduction = needNoiseReduction;
            this.NeedVolumeNormalization = needVolumeNormalization;
            this.Text = text;
            this.Model = model;
            this.Accuracy = accuracy;
            this.ClonePrompt = clonePrompt;
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