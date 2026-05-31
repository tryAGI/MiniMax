
#nullable enable

namespace MiniMax
{
    /// <summary>
    /// Provide either `text` or `text_file_id`.
    /// </summary>
    public sealed partial class AsyncTextToSpeechRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Inline text input.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Uploaded text or zip file ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_file_id")]
        public long? TextFileId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_setting")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::MiniMax.AsyncTextToSpeechVoiceSetting VoiceSetting { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_setting")]
        public global::MiniMax.AsyncTextToSpeechAudioSetting? AudioSetting { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pronunciation_dict")]
        public global::MiniMax.AsyncTextToSpeechPronunciationDict? PronunciationDict { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_boost")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MiniMax.JsonConverters.AsyncTextToSpeechRequestLanguageBoostJsonConverter))]
        public global::MiniMax.AsyncTextToSpeechRequestLanguageBoost? LanguageBoost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_modify")]
        public global::MiniMax.TtsVoiceModify? VoiceModify { get; set; }

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
        /// Initializes a new instance of the <see cref="AsyncTextToSpeechRequest" /> class.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="voiceSetting"></param>
        /// <param name="text">
        /// Inline text input.
        /// </param>
        /// <param name="textFileId">
        /// Uploaded text or zip file ID.
        /// </param>
        /// <param name="audioSetting"></param>
        /// <param name="pronunciationDict"></param>
        /// <param name="languageBoost"></param>
        /// <param name="voiceModify"></param>
        /// <param name="aigcWatermark">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AsyncTextToSpeechRequest(
            string model,
            global::MiniMax.AsyncTextToSpeechVoiceSetting voiceSetting,
            string? text,
            long? textFileId,
            global::MiniMax.AsyncTextToSpeechAudioSetting? audioSetting,
            global::MiniMax.AsyncTextToSpeechPronunciationDict? pronunciationDict,
            global::MiniMax.AsyncTextToSpeechRequestLanguageBoost? languageBoost,
            global::MiniMax.TtsVoiceModify? voiceModify,
            bool? aigcWatermark)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Text = text;
            this.TextFileId = textFileId;
            this.VoiceSetting = voiceSetting ?? throw new global::System.ArgumentNullException(nameof(voiceSetting));
            this.AudioSetting = audioSetting;
            this.PronunciationDict = pronunciationDict;
            this.LanguageBoost = languageBoost;
            this.VoiceModify = voiceModify;
            this.AigcWatermark = aigcWatermark;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncTextToSpeechRequest" /> class.
        /// </summary>
        public AsyncTextToSpeechRequest()
        {
        }

    }
}