
#nullable enable

namespace MiniMax
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageGenerationData
    {
        /// <summary>
        /// Returned when `response_format=url`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_urls")]
        public global::System.Collections.Generic.IList<string>? ImageUrls { get; set; }

        /// <summary>
        /// Returned when `response_format=base64`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_base64")]
        public global::System.Collections.Generic.IList<string>? ImageBase64 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationData" /> class.
        /// </summary>
        /// <param name="imageUrls">
        /// Returned when `response_format=url`.
        /// </param>
        /// <param name="imageBase64">
        /// Returned when `response_format=base64`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageGenerationData(
            global::System.Collections.Generic.IList<string>? imageUrls,
            global::System.Collections.Generic.IList<string>? imageBase64)
        {
            this.ImageUrls = imageUrls;
            this.ImageBase64 = imageBase64;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationData" /> class.
        /// </summary>
        public ImageGenerationData()
        {
        }

    }
}