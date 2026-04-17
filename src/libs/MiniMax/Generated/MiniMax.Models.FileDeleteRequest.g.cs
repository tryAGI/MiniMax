
#nullable enable

namespace MiniMax
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FileDeleteRequest
    {
        /// <summary>
        /// File ID to delete.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long FileId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileDeleteRequest" /> class.
        /// </summary>
        /// <param name="fileId">
        /// File ID to delete.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileDeleteRequest(
            long fileId)
        {
            this.FileId = fileId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileDeleteRequest" /> class.
        /// </summary>
        public FileDeleteRequest()
        {
        }
    }
}