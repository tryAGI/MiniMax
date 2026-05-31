
#nullable enable

namespace MiniMax
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoTaskStatusResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_id")]
        public string? TaskId { get; set; }

        /// <summary>
        /// Video generation task state.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MiniMax.JsonConverters.VideoTaskStatusJsonConverter))]
        public global::MiniMax.VideoTaskStatus? Status { get; set; }

        /// <summary>
        /// Generated file ID when successful.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        public string? FileId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_width")]
        public int? VideoWidth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_height")]
        public int? VideoHeight { get; set; }

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
        /// Initializes a new instance of the <see cref="VideoTaskStatusResponse" /> class.
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="status">
        /// Video generation task state.
        /// </param>
        /// <param name="fileId">
        /// Generated file ID when successful.
        /// </param>
        /// <param name="videoWidth"></param>
        /// <param name="videoHeight"></param>
        /// <param name="baseResp">
        /// Common status envelope returned by MiniMax API calls.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoTaskStatusResponse(
            string? taskId,
            global::MiniMax.VideoTaskStatus? status,
            string? fileId,
            int? videoWidth,
            int? videoHeight,
            global::MiniMax.BaseResponse? baseResp)
        {
            this.TaskId = taskId;
            this.Status = status;
            this.FileId = fileId;
            this.VideoWidth = videoWidth;
            this.VideoHeight = videoHeight;
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