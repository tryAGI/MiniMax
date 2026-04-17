
#nullable enable

namespace MiniMax
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextToSpeechResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::MiniMax.TtsData? Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extra_info")]
        public global::MiniMax.TtsExtraInfo? ExtraInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_id")]
        public string? TraceId { get; set; }

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
        /// Initializes a new instance of the <see cref="TextToSpeechResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="extraInfo"></param>
        /// <param name="traceId"></param>
        /// <param name="baseResp">
        /// Common status envelope returned by every MiniMax API call.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextToSpeechResponse(
            global::MiniMax.TtsData? data,
            global::MiniMax.TtsExtraInfo? extraInfo,
            string? traceId,
            global::MiniMax.BaseResponse? baseResp)
        {
            this.Data = data;
            this.ExtraInfo = extraInfo;
            this.TraceId = traceId;
            this.BaseResp = baseResp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToSpeechResponse" /> class.
        /// </summary>
        public TextToSpeechResponse()
        {
        }
    }
}