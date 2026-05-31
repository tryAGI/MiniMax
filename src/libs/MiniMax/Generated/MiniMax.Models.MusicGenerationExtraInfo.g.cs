
#nullable enable

namespace MiniMax
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MusicGenerationExtraInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("music_duration")]
        public int? MusicDuration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("music_sample_rate")]
        public int? MusicSampleRate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("music_channel")]
        public int? MusicChannel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bitrate")]
        public int? Bitrate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("music_size")]
        public int? MusicSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MusicGenerationExtraInfo" /> class.
        /// </summary>
        /// <param name="musicDuration"></param>
        /// <param name="musicSampleRate"></param>
        /// <param name="musicChannel"></param>
        /// <param name="bitrate"></param>
        /// <param name="musicSize"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MusicGenerationExtraInfo(
            int? musicDuration,
            int? musicSampleRate,
            int? musicChannel,
            int? bitrate,
            int? musicSize)
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