
#nullable enable

namespace MiniMax
{
    /// <summary>
    /// Common status envelope returned by every MiniMax API call.
    /// </summary>
    public sealed partial class BaseResponse
    {
        /// <summary>
        /// 0 for success. Non-zero indicates an error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_code")]
        public int? StatusCode { get; set; }

        /// <summary>
        /// Human-readable status message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_msg")]
        public string? StatusMsg { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseResponse" /> class.
        /// </summary>
        /// <param name="statusCode">
        /// 0 for success. Non-zero indicates an error.
        /// </param>
        /// <param name="statusMsg">
        /// Human-readable status message.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BaseResponse(
            int? statusCode,
            string? statusMsg)
        {
            this.StatusCode = statusCode;
            this.StatusMsg = statusMsg;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseResponse" /> class.
        /// </summary>
        public BaseResponse()
        {
        }
    }
}