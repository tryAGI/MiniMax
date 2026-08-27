
#nullable enable

namespace MiniMax
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MusicGenerationData
    {
        /// <summary>
        /// 1 while generating, 2 when complete.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public int? Status { get; set; }

        /// <summary>
        /// Hex audio payload or downloadable URL depending on `output_format`.
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
        /// 1 while generating, 2 when complete.
        /// </param>
        /// <param name="audio">
        /// Hex audio payload or downloadable URL depending on `output_format`.
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