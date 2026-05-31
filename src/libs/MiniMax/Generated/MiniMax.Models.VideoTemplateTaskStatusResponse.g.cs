
#nullable enable

namespace MiniMax
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoTemplateTaskStatusResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_id")]
        public string? TaskId { get; set; }

        /// <summary>
        /// Video template task state.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MiniMax.JsonConverters.VideoTemplateTaskStatusJsonConverter))]
        public global::MiniMax.VideoTemplateTaskStatus? Status { get; set; }

        /// <summary>
        /// Download URL when the task succeeds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_url")]
        public string? VideoUrl { get; set; }

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
        /// Initializes a new instance of the <see cref="VideoTemplateTaskStatusResponse" /> class.
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="status">
        /// Video template task state.
        /// </param>
        /// <param name="videoUrl">
        /// Download URL when the task succeeds.
        /// </param>
        /// <param name="baseResp">
        /// Common status envelope returned by MiniMax API calls.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoTemplateTaskStatusResponse(
            string? taskId,
            global::MiniMax.VideoTemplateTaskStatus? status,
            string? videoUrl,
            global::MiniMax.BaseResponse? baseResp)
        {
            this.TaskId = taskId;
            this.Status = status;
            this.VideoUrl = videoUrl;
            this.BaseResp = baseResp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoTemplateTaskStatusResponse" /> class.
        /// </summary>
        public VideoTemplateTaskStatusResponse()
        {
        }

    }
}