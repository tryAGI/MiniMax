
#nullable enable

namespace MiniMax
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetVoicesResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_voice")]
        public global::System.Collections.Generic.IList<global::MiniMax.SystemVoiceInfo>? SystemVoice { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_cloning")]
        public global::System.Collections.Generic.IList<global::MiniMax.VoiceCloningInfo>? VoiceCloning { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_generation")]
        public global::System.Collections.Generic.IList<global::MiniMax.VoiceGenerationInfo>? VoiceGeneration { get; set; }

        /// <summary>
        /// Common status envelope returned by MiniMax API calls.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_resp")]
        public global::MiniMax.BaseResponse? BaseResp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVoicesResponse" /> class.
        /// </summary>
        /// <param name="systemVoice"></param>
        /// <param name="voiceCloning"></param>
        /// <param name="voiceGeneration"></param>
        /// <param name="baseResp">
        /// Common status envelope returned by MiniMax API calls.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetVoicesResponse(
            global::System.Collections.Generic.IList<global::MiniMax.SystemVoiceInfo>? systemVoice,
            global::System.Collections.Generic.IList<global::MiniMax.VoiceCloningInfo>? voiceCloning,
            global::System.Collections.Generic.IList<global::MiniMax.VoiceGenerationInfo>? voiceGeneration,
            global::MiniMax.BaseResponse? baseResp)
        {
            this.SystemVoice = systemVoice;
            this.VoiceCloning = voiceCloning;
            this.VoiceGeneration = voiceGeneration;
            this.BaseResp = baseResp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVoicesResponse" /> class.
        /// </summary>
        public GetVoicesResponse()
        {
        }

    }
}