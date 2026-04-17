
#nullable enable

namespace MiniMax
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoGenerationData
    {
        /// <summary>
        /// Task ID to poll via `GET /v1/query/video_generation`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_id")]
        public string? TaskId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoGenerationData" /> class.
        /// </summary>
        /// <param name="taskId">
        /// Task ID to poll via `GET /v1/query/video_generation`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoGenerationData(
            string? taskId)
        {
            this.TaskId = taskId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoGenerationData" /> class.
        /// </summary>
        public VideoGenerationData()
        {
        }
    }
}