
#nullable enable

namespace MiniMax
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextToSpeechRequest
    {
        /// <summary>
        /// Speech model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Input text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream_options")]
        public global::MiniMax.TtsStreamOptions? StreamOptions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_setting")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::MiniMax.TtsVoiceSetting VoiceSetting { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_setting")]
        public global::MiniMax.TtsAudioSetting? AudioSetting { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pronunciation_dict")]
        public global::MiniMax.TtsPronunciationDict? PronunciationDict { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timbre_weights")]
        public global::System.Collections.Generic.IList<global::MiniMax.TimberWeight>? TimbreWeights { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_boost")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MiniMax.JsonConverters.TextToSpeechRequestLanguageBoostJsonConverter))]
        public global::MiniMax.TextToSpeechRequestLanguageBoost? LanguageBoost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_modify")]
        public global::MiniMax.TtsVoiceModify? VoiceModify { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subtitle_enable")]
        public bool? SubtitleEnable { get; set; }

        /// <summary>
        /// Default Value: sentence
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subtitle_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MiniMax.JsonConverters.TextToSpeechRequestSubtitleTypeJsonConverter))]
        public global::MiniMax.TextToSpeechRequestSubtitleType? SubtitleType { get; set; }

        /// <summary>
        /// Default Value: hex
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MiniMax.JsonConverters.TextToSpeechRequestOutputFormatJsonConverter))]
        public global::MiniMax.TextToSpeechRequestOutputFormat? OutputFormat { get; set; }

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
        /// Initializes a new instance of the <see cref="TextToSpeechRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// Speech model.
        /// </param>
        /// <param name="text">
        /// Input text.
        /// </param>
        /// <param name="voiceSetting"></param>
        /// <param name="stream">
        /// Default Value: false
        /// </param>
        /// <param name="streamOptions"></param>
        /// <param name="audioSetting"></param>
        /// <param name="pronunciationDict"></param>
        /// <param name="timbreWeights"></param>
        /// <param name="languageBoost"></param>
        /// <param name="voiceModify"></param>
        /// <param name="subtitleEnable">
        /// Default Value: false
        /// </param>
        /// <param name="subtitleType">
        /// Default Value: sentence
        /// </param>
        /// <param name="outputFormat">
        /// Default Value: hex
        /// </param>
        /// <param name="aigcWatermark">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextToSpeechRequest(
            string model,
            string text,
            global::MiniMax.TtsVoiceSetting voiceSetting,
            bool? stream,
            global::MiniMax.TtsStreamOptions? streamOptions,
            global::MiniMax.TtsAudioSetting? audioSetting,
            global::MiniMax.TtsPronunciationDict? pronunciationDict,
            global::System.Collections.Generic.IList<global::MiniMax.TimberWeight>? timbreWeights,
            global::MiniMax.TextToSpeechRequestLanguageBoost? languageBoost,
            global::MiniMax.TtsVoiceModify? voiceModify,
            bool? subtitleEnable,
            global::MiniMax.TextToSpeechRequestSubtitleType? subtitleType,
            global::MiniMax.TextToSpeechRequestOutputFormat? outputFormat,
            bool? aigcWatermark)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Stream = stream;
            this.StreamOptions = streamOptions;
            this.VoiceSetting = voiceSetting ?? throw new global::System.ArgumentNullException(nameof(voiceSetting));
            this.AudioSetting = audioSetting;
            this.PronunciationDict = pronunciationDict;
            this.TimbreWeights = timbreWeights;
            this.LanguageBoost = languageBoost;
            this.VoiceModify = voiceModify;
            this.SubtitleEnable = subtitleEnable;
            this.SubtitleType = subtitleType;
            this.OutputFormat = outputFormat;
            this.AigcWatermark = aigcWatermark;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToSpeechRequest" /> class.
        /// </summary>
        public TextToSpeechRequest()
        {
        }

    }
}