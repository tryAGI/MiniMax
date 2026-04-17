
#nullable enable

namespace MiniMax
{
    /// <summary>
    /// Voice configuration for TTS.
    /// </summary>
    public sealed partial class TtsVoiceSetting
    {
        /// <summary>
        /// Target voice identifier. Can be a system voice (e.g.,<br/>
        /// `male-qn-qingse`) or a custom cloned voice ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// Speech rate, 0.5–2.0. Default 1.0.<br/>
        /// Default Value: 1.0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        public float? Speed { get; set; }

        /// <summary>
        /// Volume, (0, 10]. Default 1.0.<br/>
        /// Default Value: 1.0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vol")]
        public float? Vol { get; set; }

        /// <summary>
        /// Pitch adjustment, -12 to 12. Default 0.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pitch")]
        public int? Pitch { get; set; }

        /// <summary>
        /// Emotional tone.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emotion")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MiniMax.JsonConverters.TtsVoiceSettingEmotionJsonConverter))]
        public global::MiniMax.TtsVoiceSettingEmotion? Emotion { get; set; }

        /// <summary>
        /// Whether to parse LaTeX formulas in the input text.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latex_read")]
        public bool? LatexRead { get; set; }

        /// <summary>
        /// Whether to normalize English text (numbers, dates, etc.).<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("english_normalization")]
        public bool? EnglishNormalization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsVoiceSetting" /> class.
        /// </summary>
        /// <param name="voiceId">
        /// Target voice identifier. Can be a system voice (e.g.,<br/>
        /// `male-qn-qingse`) or a custom cloned voice ID.
        /// </param>
        /// <param name="speed">
        /// Speech rate, 0.5–2.0. Default 1.0.<br/>
        /// Default Value: 1.0
        /// </param>
        /// <param name="vol">
        /// Volume, (0, 10]. Default 1.0.<br/>
        /// Default Value: 1.0
        /// </param>
        /// <param name="pitch">
        /// Pitch adjustment, -12 to 12. Default 0.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="emotion">
        /// Emotional tone.
        /// </param>
        /// <param name="latexRead">
        /// Whether to parse LaTeX formulas in the input text.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="englishNormalization">
        /// Whether to normalize English text (numbers, dates, etc.).<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsVoiceSetting(
            string? voiceId,
            float? speed,
            float? vol,
            int? pitch,
            global::MiniMax.TtsVoiceSettingEmotion? emotion,
            bool? latexRead,
            bool? englishNormalization)
        {
            this.VoiceId = voiceId;
            this.Speed = speed;
            this.Vol = vol;
            this.Pitch = pitch;
            this.Emotion = emotion;
            this.LatexRead = latexRead;
            this.EnglishNormalization = englishNormalization;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsVoiceSetting" /> class.
        /// </summary>
        public TtsVoiceSetting()
        {
        }
    }
}