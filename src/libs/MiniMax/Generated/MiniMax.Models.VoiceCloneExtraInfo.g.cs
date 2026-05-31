
#nullable enable

namespace MiniMax
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoiceCloneExtraInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_length")]
        public long? AudioLength { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_sample_rate")]
        public long? AudioSampleRate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_size")]
        public long? AudioSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bitrate")]
        public long? Bitrate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("word_count")]
        public long? WordCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage_characters")]
        public long? UsageCharacters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceCloneExtraInfo" /> class.
        /// </summary>
        /// <param name="audioLength"></param>
        /// <param name="audioSampleRate"></param>
        /// <param name="audioSize"></param>
        /// <param name="bitrate"></param>
        /// <param name="wordCount"></param>
        /// <param name="usageCharacters"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceCloneExtraInfo(
            long? audioLength,
            long? audioSampleRate,
            long? audioSize,
            long? bitrate,
            long? wordCount,
            long? usageCharacters)
        {
            this.AudioLength = audioLength;
            this.AudioSampleRate = audioSampleRate;
            this.AudioSize = audioSize;
            this.Bitrate = bitrate;
            this.WordCount = wordCount;
            this.UsageCharacters = usageCharacters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceCloneExtraInfo" /> class.
        /// </summary>
        public VoiceCloneExtraInfo()
        {
        }

    }
}