
#nullable enable

namespace MiniMax
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MusicGenerationData
    {
        /// <summary>
        /// 1 when partial, 2 when complete.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public int? Status { get; set; }

        /// <summary>
        /// Hex-encoded audio bytes (when `output_format=hex`) or URL (when `output_format=url`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public string? Audio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MusicGenerationData" /> class.
        /// </summary>
        /// <param name="status">
        /// 1 when partial, 2 when complete.
        /// </param>
        /// <param name="audio">
        /// Hex-encoded audio bytes (when `output_format=hex`) or URL (when `output_format=url`).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MusicGenerationData(
            int? status,
            string? audio)
        {
            this.Status = status;
            this.Audio = audio;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MusicGenerationData" /> class.
        /// </summary>
        public MusicGenerationData()
        {
        }
    }
}