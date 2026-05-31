
#nullable enable

namespace MiniMax
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AsyncTextToSpeechAudioSetting
    {
        /// <summary>
        /// Default Value: 32000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_sample_rate")]
        public long? AudioSampleRate { get; set; }

        /// <summary>
        /// Default Value: 128000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bitrate")]
        public long? Bitrate { get; set; }

        /// <summary>
        /// Default Value: mp3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MiniMax.JsonConverters.AsyncTextToSpeechAudioSettingFormatJsonConverter))]
        public global::MiniMax.AsyncTextToSpeechAudioSettingFormat? Format { get; set; }

        /// <summary>
        /// Default Value: 2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channel")]
        public long? Channel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncTextToSpeechAudioSetting" /> class.
        /// </summary>
        /// <param name="audioSampleRate">
        /// Default Value: 32000
        /// </param>
        /// <param name="bitrate">
        /// Default Value: 128000
        /// </param>
        /// <param name="format">
        /// Default Value: mp3
        /// </param>
        /// <param name="channel">
        /// Default Value: 2
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AsyncTextToSpeechAudioSetting(
            long? audioSampleRate,
            long? bitrate,
            global::MiniMax.AsyncTextToSpeechAudioSettingFormat? format,
            long? channel)
        {
            this.AudioSampleRate = audioSampleRate;
            this.Bitrate = bitrate;
            this.Format = format;
            this.Channel = channel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncTextToSpeechAudioSetting" /> class.
        /// </summary>
        public AsyncTextToSpeechAudioSetting()
        {
        }

    }
}