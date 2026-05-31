
#nullable enable

namespace MiniMax
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoiceDesignResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// Hex-encoded preview audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trial_audio")]
        public string? TrialAudio { get; set; }

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
        /// Initializes a new instance of the <see cref="VoiceDesignResponse" /> class.
        /// </summary>
        /// <param name="voiceId"></param>
        /// <param name="trialAudio">
        /// Hex-encoded preview audio.
        /// </param>
        /// <param name="baseResp">
        /// Common status envelope returned by MiniMax API calls.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceDesignResponse(
            string? voiceId,
            string? trialAudio,
            global::MiniMax.BaseResponse? baseResp)
        {
            this.VoiceId = voiceId;
            this.TrialAudio = trialAudio;
            this.BaseResp = baseResp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceDesignResponse" /> class.
        /// </summary>
        public VoiceDesignResponse()
        {
        }

    }
}