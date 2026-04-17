
#nullable enable

namespace MiniMax
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MusicGenerationExtraInfo
    {
        /// <summary>
        /// Duration of the generated music in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("music_duration")]
        public int? MusicDuration { get; set; }

        /// <summary>
        /// Sample rate in Hz.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("music_sample_rate")]
        public int? MusicSampleRate { get; set; }

        /// <summary>
        /// Number of audio channels (1=mono, 2=stereo).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("music_channel")]
        public int? MusicChannel { get; set; }

        /// <summary>
        /// Bitrate in bits/sec.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bitrate")]
        public int? Bitrate { get; set; }

        /// <summary>
        /// Size of the output audio in bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("music_size")]
        public long? MusicSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MusicGenerationExtraInfo" /> class.
        /// </summary>
        /// <param name="musicDuration">
        /// Duration of the generated music in milliseconds.
        /// </param>
        /// <param name="musicSampleRate">
        /// Sample rate in Hz.
        /// </param>
        /// <param name="musicChannel">
        /// Number of audio channels (1=mono, 2=stereo).
        /// </param>
        /// <param name="bitrate">
        /// Bitrate in bits/sec.
        /// </param>
        /// <param name="musicSize">
        /// Size of the output audio in bytes.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MusicGenerationExtraInfo(
            int? musicDuration,
            int? musicSampleRate,
            int? musicChannel,
            int? bitrate,
            long? musicSize)
        {
            this.MusicDuration = musicDuration;
            this.MusicSampleRate = musicSampleRate;
            this.MusicChannel = musicChannel;
            this.Bitrate = bitrate;
            this.MusicSize = musicSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MusicGenerationExtraInfo" /> class.
        /// </summary>
        public MusicGenerationExtraInfo()
        {
        }
    }
}