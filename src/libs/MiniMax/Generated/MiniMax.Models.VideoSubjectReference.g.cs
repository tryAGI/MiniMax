
#nullable enable

namespace MiniMax
{
    /// <summary>
    /// Subject reference for character-consistent video generation.
    /// </summary>
    public sealed partial class VideoSubjectReference
    {
        /// <summary>
        /// Reference type (e.g., `character`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MiniMax.JsonConverters.VideoSubjectReferenceTypeJsonConverter))]
        public global::MiniMax.VideoSubjectReferenceType? Type { get; set; }

        /// <summary>
        /// Array of reference image URLs or base64 strings (at most 1 item today).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public global::System.Collections.Generic.IList<string>? Image { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoSubjectReference" /> class.
        /// </summary>
        /// <param name="type">
        /// Reference type (e.g., `character`).
        /// </param>
        /// <param name="image">
        /// Array of reference image URLs or base64 strings (at most 1 item today).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoSubjectReference(
            global::MiniMax.VideoSubjectReferenceType? type,
            global::System.Collections.Generic.IList<string>? image)
        {
            this.Type = type;
            this.Image = image;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoSubjectReference" /> class.
        /// </summary>
        public VideoSubjectReference()
        {
        }
    }
}