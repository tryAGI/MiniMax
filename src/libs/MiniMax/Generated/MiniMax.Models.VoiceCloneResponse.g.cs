
#nullable enable

namespace MiniMax
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VoiceCloneResponse
    {
        /// <summary>
        /// Whether the input audio was flagged by content checks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_sensitive")]
        public bool? InputSensitive { get; set; }

        /// <summary>
        /// Flag category when the input audio is sensitive.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_sensitive_type")]
        public int? InputSensitiveType { get; set; }

        /// <summary>
        /// Verification audio URL when sample text was supplied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("demo_audio")]
        public string? DemoAudio { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extra_info")]
        public global::MiniMax.VoiceCloneExtraInfo? ExtraInfo { get; set; }

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
        /// Initializes a new instance of the <see cref="VoiceCloneResponse" /> class.
        /// </summary>
        /// <param name="inputSensitive">
        /// Whether the input audio was flagged by content checks.
        /// </param>
        /// <param name="inputSensitiveType">
        /// Flag category when the input audio is sensitive.
        /// </param>
        /// <param name="demoAudio">
        /// Verification audio URL when sample text was supplied.
        /// </param>
        /// <param name="extraInfo"></param>
        /// <param name="baseResp">
        /// Common status envelope returned by MiniMax API calls.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceCloneResponse(
            bool? inputSensitive,
            int? inputSensitiveType,
            string? demoAudio,
            global::MiniMax.VoiceCloneExtraInfo? extraInfo,
            global::MiniMax.BaseResponse? baseResp)
        {
            this.InputSensitive = inputSensitive;
            this.InputSensitiveType = inputSensitiveType;
            this.DemoAudio = demoAudio;
            this.ExtraInfo = extraInfo;
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