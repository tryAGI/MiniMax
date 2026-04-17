
#nullable enable

namespace MiniMax
{
    /// <summary>
    /// Audio output configuration for TTS.
    /// </summary>
    public sealed partial class TtsAudioSetting
    {
        /// <summary>
        /// Sample rate in Hz. Supported — 8000, 16000, 22050, 24000, 32000, 44100.<br/>
        /// Default Value: 32000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_rate")]
        public int? SampleRate { get; set; }

        /// <summary>
        /// Bitrate in bits/sec (MP3 only). Supported — 32000, 64000, 128000, 256000.<br/>
        /// Default Value: 128000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bitrate")]
        public int? Bitrate { get; set; }

        /// <summary>
        /// Output audio format.<br/>
        /// Default Value: mp3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MiniMax.JsonConverters.TtsAudioSettingFormatJsonConverter))]
        public global::MiniMax.TtsAudioSettingFormat? Format { get; set; }

        /// <summary>
        /// 1 (mono) or 2 (stereo). Default 1.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channel")]
        public int? Channel { get; set; }

        /// <summary>
        /// Force constant bitrate MP3 encoding (streaming only).<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("force_cbr")]
        public bool? ForceCbr { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsAudioSetting" /> class.
        /// </summary>
        /// <param name="sampleRate">
        /// Sample rate in Hz. Supported — 8000, 16000, 22050, 24000, 32000, 44100.<br/>
        /// Default Value: 32000
        /// </param>
        /// <param name="bitrate">
        /// Bitrate in bits/sec (MP3 only). Supported — 32000, 64000, 128000, 256000.<br/>
        /// Default Value: 128000
        /// </param>
        /// <param name="format">
        /// Output audio format.<br/>
        /// Default Value: mp3
        /// </param>
        /// <param name="channel">
        /// 1 (mono) or 2 (stereo). Default 1.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="forceCbr">
        /// Force constant bitrate MP3 encoding (streaming only).<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsAudioSetting(
            int? sampleRate,
            int? bitrate,
            global::MiniMax.TtsAudioSettingFormat? format,
            int? channel,
            bool? forceCbr)
        {
            this.SampleRate = sampleRate;
            this.Bitrate = bitrate;
            this.Format = format;
            this.Channel = channel;
            this.ForceCbr = forceCbr;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsAudioSetting" /> class.
        /// </summary>
        public TtsAudioSetting()
        {
        }
    }
}