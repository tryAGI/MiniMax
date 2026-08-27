
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
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_id")]
        public string? TraceId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extra_info")]
        public global::MiniMax.TtsExtraInfo? ExtraInfo { get; set; }

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
        /// Initializes a new instance of the <see cref="TextToSpeechResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="traceId"></param>
        /// <param name="extraInfo"></param>
        /// <param name="baseResp">
        /// Common status envelope returned by MiniMax API calls.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextToSpeechResponse(
            global::MiniMax.TtsData? data,
            string? traceId,
            global::MiniMax.TtsExtraInfo? extraInfo,
            global::MiniMax.BaseResponse? baseResp)
        {
            this.Data = data;
            this.TraceId = traceId;
            this.ExtraInfo = extraInfo;
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