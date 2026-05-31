
#nullable enable

namespace MiniMax
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageSubjectReference
    {
        /// <summary>
        /// Reference subject type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MiniMax.JsonConverters.ImageSubjectReferenceTypeJsonConverter))]
        public global::MiniMax.ImageSubjectReferenceType Type { get; set; }

        /// <summary>
        /// Reference image URL or data URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ImageFile { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageSubjectReference" /> class.
        /// </summary>
        /// <param name="imageFile">
        /// Reference image URL or data URL.
        /// </param>
        /// <param name="type">
        /// Reference subject type.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageSubjectReference(
            string imageFile,
            global::MiniMax.ImageSubjectReferenceType type)
        {
            this.Type = type;
            this.ImageFile = imageFile ?? throw new global::System.ArgumentNullException(nameof(imageFile));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageSubjectReference" /> class.
        /// </summary>
        public ImageSubjectReference()
        {
        }

    }
}