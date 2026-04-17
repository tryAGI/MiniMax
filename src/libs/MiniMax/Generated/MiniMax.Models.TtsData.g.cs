
#nullable enable

namespace MiniMax
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TtsData
    {
        /// <summary>
        /// Hex-encoded audio bytes (or URL if `output_format=url`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public string? Audio { get; set; }

        /// <summary>
        /// 1 when partial, 2 when complete.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public int? Status { get; set; }

        /// <summary>
        /// URL of the generated subtitle file (when `subtitle_enable=true`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subtitle_file")]
        public string? SubtitleFile { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsData" /> class.
        /// </summary>
        /// <param name="audio">
        /// Hex-encoded audio bytes (or URL if `output_format=url`).
        /// </param>
        /// <param name="status">
        /// 1 when partial, 2 when complete.
        /// </param>
        /// <param name="subtitleFile">
        /// URL of the generated subtitle file (when `subtitle_enable=true`).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsData(
            string? audio,
            int? status,
            string? subtitleFile)
        {
            this.Audio = audio;
            this.Status = status;
            this.SubtitleFile = subtitleFile;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsData" /> class.
        /// </summary>
        public TtsData()
        {
        }
    }
}