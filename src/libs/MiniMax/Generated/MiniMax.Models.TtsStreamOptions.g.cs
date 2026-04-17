
#nullable enable

namespace MiniMax
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TtsStreamOptions
    {
        /// <summary>
        /// Omit the aggregated-audio chunk at the end of the stream.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude_aggregated_audio")]
        public bool? ExcludeAggregatedAudio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsStreamOptions" /> class.
        /// </summary>
        /// <param name="excludeAggregatedAudio">
        /// Omit the aggregated-audio chunk at the end of the stream.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsStreamOptions(
            bool? excludeAggregatedAudio)
        {
            this.ExcludeAggregatedAudio = excludeAggregatedAudio;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsStreamOptions" /> class.
        /// </summary>
        public TtsStreamOptions()
        {
        }
    }
}