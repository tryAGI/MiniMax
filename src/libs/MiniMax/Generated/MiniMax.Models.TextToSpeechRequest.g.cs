
#nullable enable

namespace MiniMax
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextToSpeechRequest
    {
        /// <summary>
        /// TTS model version: `speech-2.8-hd`, `speech-2.8-turbo`,<br/>
        /// `speech-2.6-hd`, `speech-2.6-turbo`, `speech-02-hd`,<br/>
        /// `speech-02-turbo`, `speech-01-hd`, `speech-01-turbo`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Input text, up to 10,000 characters. Use `\n` for paragraph breaks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Whether to stream the output.<br/>
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
        /// Voice configuration for TTS.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_setting")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::MiniMax.TtsVoiceSetting VoiceSetting { get; set; }

        /// <summary>
        /// Audio output configuration for TTS.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_setting")]
        public global::MiniMax.TtsAudioSetting? AudioSetting { get; set; }

        /// <summary>
        /// Custom pronunciation rules.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pronunciation_dict")]
        public global::MiniMax.TtsPronunciationDict? PronunciationDict { get; set; }

        /// <summary>
        /// Voice effect/modulation settings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_modify")]
        public global::MiniMax.TtsVoiceModify? VoiceModify { get; set; }

        /// <summary>
        /// Mix multiple voices by weight (up to 4 entries).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timber_weights")]
        public global::System.Collections.Generic.IList<global::MiniMax.TimberWeight>? TimberWeights { get; set; }

        /// <summary>
        /// Bias pronunciation toward a specific language, or `auto` to<br/>
        /// auto-detect. Examples — `English`, `Chinese`, `Japanese`,<br/>
        /// `Korean`, `auto`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_boost")]
        public string? LanguageBoost { get; set; }

        /// <summary>
        /// Output format (non-streaming only).<br/>
        /// Default Value: hex
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MiniMax.JsonConverters.TextToSpeechRequestOutputFormatJsonConverter))]
        public global::MiniMax.TextToSpeechRequestOutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// Whether to return subtitle files alongside the audio.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subtitle_enable")]
        public bool? SubtitleEnable { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToSpeechRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// TTS model version: `speech-2.8-hd`, `speech-2.8-turbo`,<br/>
        /// `speech-2.6-hd`, `speech-2.6-turbo`, `speech-02-hd`,<br/>
        /// `speech-02-turbo`, `speech-01-hd`, `speech-01-turbo`.
        /// </param>
        /// <param name="text">
        /// Input text, up to 10,000 characters. Use `\n` for paragraph breaks.
        /// </param>
        /// <param name="voiceSetting">
        /// Voice configuration for TTS.
        /// </param>
        /// <param name="stream">
        /// Whether to stream the output.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="streamOptions"></param>
        /// <param name="audioSetting">
        /// Audio output configuration for TTS.
        /// </param>
        /// <param name="pronunciationDict">
        /// Custom pronunciation rules.
        /// </param>
        /// <param name="voiceModify">
        /// Voice effect/modulation settings.
        /// </param>
        /// <param name="timberWeights">
        /// Mix multiple voices by weight (up to 4 entries).
        /// </param>
        /// <param name="languageBoost">
        /// Bias pronunciation toward a specific language, or `auto` to<br/>
        /// auto-detect. Examples — `English`, `Chinese`, `Japanese`,<br/>
        /// `Korean`, `auto`.
        /// </param>
        /// <param name="outputFormat">
        /// Output format (non-streaming only).<br/>
        /// Default Value: hex
        /// </param>
        /// <param name="subtitleEnable">
        /// Whether to return subtitle files alongside the audio.<br/>
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
            global::MiniMax.TtsVoiceModify? voiceModify,
            global::System.Collections.Generic.IList<global::MiniMax.TimberWeight>? timberWeights,
            string? languageBoost,
            global::MiniMax.TextToSpeechRequestOutputFormat? outputFormat,
            bool? subtitleEnable)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Stream = stream;
            this.StreamOptions = streamOptions;
            this.VoiceSetting = voiceSetting ?? throw new global::System.ArgumentNullException(nameof(voiceSetting));
            this.AudioSetting = audioSetting;
            this.PronunciationDict = pronunciationDict;
            this.VoiceModify = voiceModify;
            this.TimberWeights = timberWeights;
            this.LanguageBoost = languageBoost;
            this.OutputFormat = outputFormat;
            this.SubtitleEnable = subtitleEnable;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToSpeechRequest" /> class.
        /// </summary>
        public TextToSpeechRequest()
        {
        }
    }
}