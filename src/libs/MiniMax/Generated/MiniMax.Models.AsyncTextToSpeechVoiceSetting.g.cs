
#nullable enable

namespace MiniMax
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AsyncTextToSpeechVoiceSetting
    {
        /// <summary>
        /// 
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emotion")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MiniMax.JsonConverters.AsyncTextToSpeechVoiceSettingEmotionJsonConverter))]
        public global::MiniMax.AsyncTextToSpeechVoiceSettingEmotion? Emotion { get; set; }

        /// <summary>
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
        /// Initializes a new instance of the <see cref="AsyncTextToSpeechVoiceSetting" /> class.
        /// </summary>
        /// <param name="voiceId"></param>
        /// <param name="speed">
        /// Default Value: 1
        /// </param>
        /// <param name="vol">
        /// Default Value: 1
        /// </param>
        /// <param name="pitch">
        /// Default Value: 0
        /// </param>
        /// <param name="emotion"></param>
        /// <param name="englishNormalization">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AsyncTextToSpeechVoiceSetting(
            string voiceId,
            float? speed,
            float? vol,
            int? pitch,
            global::MiniMax.AsyncTextToSpeechVoiceSettingEmotion? emotion,
            bool? englishNormalization)
        {
            this.VoiceId = voiceId ?? throw new global::System.ArgumentNullException(nameof(voiceId));
            this.Speed = speed;
            this.Vol = vol;
            this.Pitch = pitch;
            this.Emotion = emotion;
            this.EnglishNormalization = englishNormalization;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncTextToSpeechVoiceSetting" /> class.
        /// </summary>
        public AsyncTextToSpeechVoiceSetting()
        {
        }

    }
}