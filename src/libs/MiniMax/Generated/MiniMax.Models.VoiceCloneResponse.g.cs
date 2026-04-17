
#nullable enable

namespace MiniMax
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoiceCloneResponse
    {
        /// <summary>
        /// Whether the reference audio contained sensitive content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_sensitive")]
        public bool? InputSensitive { get; set; }

        /// <summary>
        /// Sensitive content category (if any).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_sensitive_type")]
        public int? InputSensitiveType { get; set; }

        /// <summary>
        /// URL of the synthesized demo audio (when `text` was supplied).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("demo_audio")]
        public string? DemoAudio { get; set; }

        /// <summary>
        /// Common status envelope returned by every MiniMax API call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_resp")]
        public global::MiniMax.BaseResponse? BaseResp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceCloneResponse" /> class.
        /// </summary>
        /// <param name="inputSensitive">
        /// Whether the reference audio contained sensitive content.
        /// </param>
        /// <param name="inputSensitiveType">
        /// Sensitive content category (if any).
        /// </param>
        /// <param name="demoAudio">
        /// URL of the synthesized demo audio (when `text` was supplied).
        /// </param>
        /// <param name="baseResp">
        /// Common status envelope returned by every MiniMax API call.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceCloneResponse(
            bool? inputSensitive,
            int? inputSensitiveType,
            string? demoAudio,
            global::MiniMax.BaseResponse? baseResp)
        {
            this.InputSensitive = inputSensitive;
            this.InputSensitiveType = inputSensitiveType;
            this.DemoAudio = demoAudio;
            this.BaseResp = baseResp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceCloneResponse" /> class.
        /// </summary>
        public VoiceCloneResponse()
        {
        }
    }
}