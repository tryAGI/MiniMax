
#nullable enable

namespace MiniMax
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoGenerationResponse
    {
        /// <summary>
        /// Task ID to poll via `GET /v1/query/video_generation`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_id")]
        public string? TaskId { get; set; }

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
        /// Initializes a new instance of the <see cref="VideoGenerationResponse" /> class.
        /// </summary>
        /// <param name="taskId">
        /// Task ID to poll via `GET /v1/query/video_generation`.
        /// </param>
        /// <param name="baseResp">
        /// Common status envelope returned by every MiniMax API call.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoGenerationResponse(
            string? taskId,
            global::MiniMax.BaseResponse? baseResp)
        {
            this.TaskId = taskId;
            this.BaseResp = baseResp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoGenerationResponse" /> class.
        /// </summary>
        public VideoGenerationResponse()
        {
        }
    }
}