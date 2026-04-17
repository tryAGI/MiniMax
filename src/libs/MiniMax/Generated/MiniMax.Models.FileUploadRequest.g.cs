
#nullable enable

namespace MiniMax
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FileUploadRequest
    {
        /// <summary>
        /// File purpose — `voice_clone`, `prompt_audio`, `retrieval`,<br/>
        /// `fine-tune`, `fine-tune-results`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("purpose")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Purpose { get; set; }

        /// <summary>
        /// The file to upload (MP3, M4A, WAV, image, video, etc.).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] File { get; set; }

        /// <summary>
        /// The file to upload (MP3, M4A, WAV, image, video, etc.).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileUploadRequest" /> class.
        /// </summary>
        /// <param name="purpose">
        /// File purpose — `voice_clone`, `prompt_audio`, `retrieval`,<br/>
        /// `fine-tune`, `fine-tune-results`.
        /// </param>
        /// <param name="file">
        /// The file to upload (MP3, M4A, WAV, image, video, etc.).
        /// </param>
        /// <param name="filename">
        /// The file to upload (MP3, M4A, WAV, image, video, etc.).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileUploadRequest(
            string purpose,
            byte[] file,
            string filename)
        {
            this.Purpose = purpose ?? throw new global::System.ArgumentNullException(nameof(purpose));
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileUploadRequest" /> class.
        /// </summary>
        public FileUploadRequest()
        {
        }
    }
}