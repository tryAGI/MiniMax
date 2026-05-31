
#nullable enable

namespace MiniMax
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TtsAudioSetting
    {
        /// <summary>
        /// Default Value: 32000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_rate")]
        public int? SampleRate { get; set; }

        /// <summary>
        /// Default Value: 128000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bitrate")]
        public int? Bitrate { get; set; }

        /// <summary>
        /// Default Value: mp3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MiniMax.JsonConverters.TtsAudioSettingFormatJsonConverter))]
        public global::MiniMax.TtsAudioSettingFormat? Format { get; set; }

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channel")]
        public int? Channel { get; set; }

        /// <summary>
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
        /// Default Value: 32000
        /// </param>
        /// <param name="bitrate">
        /// Default Value: 128000
        /// </param>
        /// <param name="format">
        /// Default Value: mp3
        /// </param>
        /// <param name="channel">
        /// Default Value: 1
        /// </param>
        /// <param name="forceCbr">
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