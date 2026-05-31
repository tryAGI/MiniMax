
#nullable enable

namespace MiniMax
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetVoicesRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MiniMax.JsonConverters.GetVoicesRequestVoiceTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::MiniMax.GetVoicesRequestVoiceType VoiceType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVoicesRequest" /> class.
        /// </summary>
        /// <param name="voiceType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetVoicesRequest(
            global::MiniMax.GetVoicesRequestVoiceType voiceType)
        {
            this.VoiceType = voiceType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVoicesRequest" /> class.
        /// </summary>
        public GetVoicesRequest()
        {
        }

    }
}