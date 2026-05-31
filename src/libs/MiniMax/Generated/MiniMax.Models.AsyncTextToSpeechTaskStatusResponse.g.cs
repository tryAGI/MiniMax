
#nullable enable

namespace MiniMax
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AsyncTextToSpeechTaskStatusResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_id")]
        public long? TaskId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MiniMax.JsonConverters.AsyncTextToSpeechTaskStatusJsonConverter))]
        public global::MiniMax.AsyncTextToSpeechTaskStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        public long? FileId { get; set; }

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
        /// Initializes a new instance of the <see cref="AsyncTextToSpeechTaskStatusResponse" /> class.
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="status"></param>
        /// <param name="fileId"></param>
        /// <param name="baseResp">
        /// Common status envelope returned by MiniMax API calls.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AsyncTextToSpeechTaskStatusResponse(
            long? taskId,
            global::MiniMax.AsyncTextToSpeechTaskStatus? status,
            long? fileId,
            global::MiniMax.BaseResponse? baseResp)
        {
            this.TaskId = taskId;
            this.Status = status;
            this.FileId = fileId;
            this.BaseResp = baseResp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncTextToSpeechTaskStatusResponse" /> class.
        /// </summary>
        public AsyncTextToSpeechTaskStatusResponse()
        {
        }

    }
}