
#nullable enable

namespace MiniMax
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TtsExtraInfo
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
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MiniMax.JsonConverters.TtsExtraInfoAudioFormatJsonConverter))]
        public global::MiniMax.TtsExtraInfoAudioFormat? AudioFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_channel")]
        public long? AudioChannel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invisible_character_ratio")]
        public float? InvisibleCharacterRatio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage_characters")]
        public long? UsageCharacters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("word_count")]
        public long? WordCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsExtraInfo" /> class.
        /// </summary>
        /// <param name="audioLength"></param>
        /// <param name="audioSampleRate"></param>
        /// <param name="audioSize"></param>
        /// <param name="bitrate"></param>
        /// <param name="audioFormat"></param>
        /// <param name="audioChannel"></param>
        /// <param name="invisibleCharacterRatio"></param>
        /// <param name="usageCharacters"></param>
        /// <param name="wordCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsExtraInfo(
            long? audioLength,
            long? audioSampleRate,
            long? audioSize,
            long? bitrate,
            global::MiniMax.TtsExtraInfoAudioFormat? audioFormat,
            long? audioChannel,
            float? invisibleCharacterRatio,
            long? usageCharacters,
            long? wordCount)
        {
            this.AudioLength = audioLength;
            this.AudioSampleRate = audioSampleRate;
            this.AudioSize = audioSize;
            this.Bitrate = bitrate;
            this.AudioFormat = audioFormat;
            this.AudioChannel = audioChannel;
            this.InvisibleCharacterRatio = invisibleCharacterRatio;
            this.UsageCharacters = usageCharacters;
            this.WordCount = wordCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsExtraInfo" /> class.
        /// </summary>
        public TtsExtraInfo()
        {
        }

    }
}