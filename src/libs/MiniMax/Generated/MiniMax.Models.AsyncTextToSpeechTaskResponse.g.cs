
#nullable enable

namespace MiniMax
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AsyncTextToSpeechTaskResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_id")]
        public long? TaskId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        public long? FileId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_token")]
        public string? TaskToken { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage_characters")]
        public int? UsageCharacters { get; set; }

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
        /// Initializes a new instance of the <see cref="AsyncTextToSpeechTaskResponse" /> class.
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="fileId"></param>
        /// <param name="taskToken"></param>
        /// <param name="usageCharacters"></param>
        /// <param name="baseResp">
        /// Common status envelope returned by MiniMax API calls.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AsyncTextToSpeechTaskResponse(
            long? taskId,
            long? fileId,
            string? taskToken,
            int? usageCharacters,
            global::MiniMax.BaseResponse? baseResp)
        {
            this.TaskId = taskId;
            this.FileId = fileId;
            this.TaskToken = taskToken;
            this.UsageCharacters = usageCharacters;
            this.BaseResp = baseResp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncTextToSpeechTaskResponse" /> class.
        /// </summary>
        public AsyncTextToSpeechTaskResponse()
        {
        }

    }
}