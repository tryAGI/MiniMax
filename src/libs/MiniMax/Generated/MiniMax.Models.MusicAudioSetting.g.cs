
#nullable enable

namespace MiniMax
{
    /// <summary>
    /// Audio output configuration for music generation.
    /// </summary>
    public sealed partial class MusicAudioSetting
    {
        /// <summary>
        /// Audio sample rate in Hz (e.g., 44100).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_rate")]
        public int? SampleRate { get; set; }

        /// <summary>
        /// Bitrate in bits/sec (e.g., 256000).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bitrate")]
        public int? Bitrate { get; set; }

        /// <summary>
        /// Audio format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MiniMax.JsonConverters.MusicAudioSettingFormatJsonConverter))]
        public global::MiniMax.MusicAudioSettingFormat? Format { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MusicAudioSetting" /> class.
        /// </summary>
        /// <param name="sampleRate">
        /// Audio sample rate in Hz (e.g., 44100).
        /// </param>
        /// <param name="bitrate">
        /// Bitrate in bits/sec (e.g., 256000).
        /// </param>
        /// <param name="format">
        /// Audio format.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MusicAudioSetting(
            int? sampleRate,
            int? bitrate,
            global::MiniMax.MusicAudioSettingFormat? format)
        {
            this.SampleRate = sampleRate;
            this.Bitrate = bitrate;
            this.Format = format;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MusicAudioSetting" /> class.
        /// </summary>
        public MusicAudioSetting()
        {
        }
    }
}