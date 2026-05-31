
#nullable enable

namespace MiniMax
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TtsData
    {
        /// <summary>
        /// Hex-encoded audio or downloadable URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public string? Audio { get; set; }

        /// <summary>
        /// Subtitle download URL when subtitles are enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subtitle_file")]
        public string? SubtitleFile { get; set; }

        /// <summary>
        /// 1 while streaming, 2 when complete.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public int? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsData" /> class.
        /// </summary>
        /// <param name="audio">
        /// Hex-encoded audio or downloadable URL.
        /// </param>
        /// <param name="subtitleFile">
        /// Subtitle download URL when subtitles are enabled.
        /// </param>
        /// <param name="status">
        /// 1 while streaming, 2 when complete.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsData(
            string? audio,
            string? subtitleFile,
            int? status)
        {
            this.Audio = audio;
            this.SubtitleFile = subtitleFile;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsData" /> class.
        /// </summary>
        public TtsData()
        {
        }

    }
}