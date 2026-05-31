
#nullable enable

namespace MiniMax
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SystemVoiceInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_name")]
        public string? VoiceName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public global::System.Collections.Generic.IList<string>? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemVoiceInfo" /> class.
        /// </summary>
        /// <param name="voiceId"></param>
        /// <param name="voiceName"></param>
        /// <param name="description"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SystemVoiceInfo(
            string? voiceId,
            string? voiceName,
            global::System.Collections.Generic.IList<string>? description)
        {
            this.VoiceId = voiceId;
            this.VoiceName = voiceName;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemVoiceInfo" /> class.
        /// </summary>
        public SystemVoiceInfo()
        {
        }

    }
}