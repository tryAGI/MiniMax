
#nullable enable

namespace MiniMax
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FileInfo
    {
        /// <summary>
        /// Unique file identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        public long? FileId { get; set; }

        /// <summary>
        /// File size in bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bytes")]
        public long? Bytes { get; set; }

        /// <summary>
        /// Creation timestamp (Unix seconds).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public long? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("purpose")]
        public string? Purpose { get; set; }

        /// <summary>
        /// Temporary download URL (only present on retrieve).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("download_url")]
        public string? DownloadUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileInfo" /> class.
        /// </summary>
        /// <param name="fileId">
        /// Unique file identifier.
        /// </param>
        /// <param name="bytes">
        /// File size in bytes.
        /// </param>
        /// <param name="createdAt">
        /// Creation timestamp (Unix seconds).
        /// </param>
        /// <param name="filename"></param>
        /// <param name="purpose"></param>
        /// <param name="downloadUrl">
        /// Temporary download URL (only present on retrieve).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileInfo(
            long? fileId,
            long? bytes,
            long? createdAt,
            string? filename,
            string? purpose,
            string? downloadUrl)
        {
            this.FileId = fileId;
            this.Bytes = bytes;
            this.CreatedAt = createdAt;
            this.Filename = filename;
            this.Purpose = purpose;
            this.DownloadUrl = downloadUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileInfo" /> class.
        /// </summary>
        public FileInfo()
        {
        }
    }
}