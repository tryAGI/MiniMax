
#nullable enable

namespace MiniMax
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VoiceGenerationInfo
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        public string? VoiceId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public global::System.Collections.Generic.IList<string>? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_time")]
        public string? CreatedTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceGenerationInfo" /> class.
        /// </summary>
        /// <param name="voiceId"></param>
        /// <param name="description"></param>
        /// <param name="createdTime"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceGenerationInfo(
            string? voiceId,
            global::System.Collections.Generic.IList<string>? description,
            string? createdTime)
        {
            this.VoiceId = voiceId;
            this.Description = description;
            this.CreatedTime = createdTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceGenerationInfo" /> class.
        /// </summary>
        public VoiceGenerationInfo()
        {
        }

    }
}