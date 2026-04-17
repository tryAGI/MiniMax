
#nullable enable

namespace MiniMax
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoTaskStatusResponse
    {
        /// <summary>
        /// Task ID passed in.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_id")]
        public string? TaskId { get; set; }

        /// <summary>
        /// Task lifecycle status.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MiniMax.JsonConverters.VideoTaskStatusJsonConverter))]
        public global::MiniMax.VideoTaskStatus? Status { get; set; }

        /// <summary>
        /// File ID of the generated video (only set when `status=Success`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        public string? FileId { get; set; }

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
        /// Initializes a new instance of the <see cref="VideoTaskStatusResponse" /> class.
        /// </summary>
        /// <param name="taskId">
        /// Task ID passed in.
        /// </param>
        /// <param name="status">
        /// Task lifecycle status.
        /// </param>
        /// <param name="fileId">
        /// File ID of the generated video (only set when `status=Success`).
        /// </param>
        /// <param name="baseResp">
        /// Common status envelope returned by every MiniMax API call.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoTaskStatusResponse(
            string? taskId,
            global::MiniMax.VideoTaskStatus? status,
            string? fileId,
            global::MiniMax.BaseResponse? baseResp)
        {
            this.TaskId = taskId;
            this.Status = status;
            this.FileId = fileId;
            this.BaseResp = baseResp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoTaskStatusResponse" /> class.
        /// </summary>
        public VideoTaskStatusResponse()
        {
        }
    }
}