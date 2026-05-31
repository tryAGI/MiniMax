
#nullable enable

namespace MiniMax
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoSubjectReference
    {
        /// <summary>
        /// Reference subject type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MiniMax.JsonConverters.VideoSubjectReferenceTypeJsonConverter))]
        public global::MiniMax.VideoSubjectReferenceType Type { get; set; }

        /// <summary>
        /// Reference image URLs or data URLs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Image { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoSubjectReference" /> class.
        /// </summary>
        /// <param name="image">
        /// Reference image URLs or data URLs.
        /// </param>
        /// <param name="type">
        /// Reference subject type.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoSubjectReference(
            global::System.Collections.Generic.IList<string> image,
            global::MiniMax.VideoSubjectReferenceType type)
        {
            this.Type = type;
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoSubjectReference" /> class.
        /// </summary>
        public VideoSubjectReference()
        {
        }

    }
}