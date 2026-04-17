
#nullable enable

namespace MiniMax
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TtsExtraInfo
    {
        /// <summary>
        /// Duration in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_length")]
        public int? AudioLength { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_sample_rate")]
        public int? AudioSampleRate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_size")]
        public int? AudioSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bitrate")]
        public int? Bitrate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("word_count")]
        public int? WordCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invisible_character_ratio")]
        public float? InvisibleCharacterRatio { get; set; }

        /// <summary>
        /// Billable character count.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage_characters")]
        public int? UsageCharacters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_format")]
        public string? AudioFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_channel")]
        public int? AudioChannel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsExtraInfo" /> class.
        /// </summary>
        /// <param name="audioLength">
        /// Duration in milliseconds.
        /// </param>
        /// <param name="audioSampleRate"></param>
        /// <param name="audioSize"></param>
        /// <param name="bitrate"></param>
        /// <param name="wordCount"></param>
        /// <param name="invisibleCharacterRatio"></param>
        /// <param name="usageCharacters">
        /// Billable character count.
        /// </param>
        /// <param name="audioFormat"></param>
        /// <param name="audioChannel"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsExtraInfo(
            int? audioLength,
            int? audioSampleRate,
            int? audioSize,
            int? bitrate,
            int? wordCount,
            float? invisibleCharacterRatio,
            int? usageCharacters,
            string? audioFormat,
            int? audioChannel)
        {
            this.AudioLength = audioLength;
            this.AudioSampleRate = audioSampleRate;
            this.AudioSize = audioSize;
            this.Bitrate = bitrate;
            this.WordCount = wordCount;
            this.InvisibleCharacterRatio = invisibleCharacterRatio;
            this.UsageCharacters = usageCharacters;
            this.AudioFormat = audioFormat;
            this.AudioChannel = audioChannel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsExtraInfo" /> class.
        /// </summary>
        public TtsExtraInfo()
        {
        }
    }
}