
#nullable enable

namespace MiniMax
{
    /// <summary>
    /// Voice mix entry (combine multiple voices with weights).
    /// </summary>
    public sealed partial class TimberWeight
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// Weight, 1-100.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weight")]
        public int? Weight { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TimberWeight" /> class.
        /// </summary>
        /// <param name="voiceId"></param>
        /// <param name="weight">
        /// Weight, 1-100.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TimberWeight(
            string? voiceId,
            int? weight)
        {
            this.VoiceId = voiceId;
            this.Weight = weight;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TimberWeight" /> class.
        /// </summary>
        public TimberWeight()
        {
        }
    }
}