
#nullable enable

namespace MiniMax
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TtsVoiceSetting
    {
        /// <summary>
        /// Voice identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VoiceId { get; set; }

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        public float? Speed { get; set; }

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vol")]
        public float? Vol { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pitch")]
        public int? Pitch { get; set; }

        /// <summary>
        /// Optional speaking emotion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emotion")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MiniMax.JsonConverters.TtsVoiceSettingEmotionJsonConverter))]
        public global::MiniMax.TtsVoiceSettingEmotion? Emotion { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_normalization")]
        public bool? TextNormalization { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latex_read")]
        public bool? LatexRead { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsVoiceSetting" /> class.
        /// </summary>
        /// <param name="voiceId">
        /// Voice identifier.
        /// </param>
        /// <param name="speed">
        /// Default Value: 1
        /// </param>
        /// <param name="vol">
        /// Default Value: 1
        /// </param>
        /// <param name="pitch">
        /// Default Value: 0
        /// </param>
        /// <param name="emotion">
        /// Optional speaking emotion.
        /// </param>
        /// <param name="textNormalization">
        /// Default Value: false
        /// </param>
        /// <param name="latexRead">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsVoiceSetting(
            string voiceId,
            float? speed,
            float? vol,
            int? pitch,
            global::MiniMax.TtsVoiceSettingEmotion? emotion,
            bool? textNormalization,
            bool? latexRead)
        {
            this.VoiceId = voiceId ?? throw new global::System.ArgumentNullException(nameof(voiceId));
            this.Speed = speed;
            this.Vol = vol;
            this.Pitch = pitch;
            this.Emotion = emotion;
            this.TextNormalization = textNormalization;
            this.LatexRead = latexRead;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsVoiceSetting" /> class.
        /// </summary>
        public TtsVoiceSetting()
        {
        }

    }
}