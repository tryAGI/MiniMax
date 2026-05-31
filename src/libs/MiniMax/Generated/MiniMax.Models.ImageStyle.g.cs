
#nullable enable

namespace MiniMax
{
    /// <summary>
    /// Optional style configuration for `image-01-live`.
    /// </summary>
    public sealed partial class ImageStyle
    {
        /// <summary>
        /// Style type from the current upstream catalog.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_type")]
        public string? StyleType { get; set; }

        /// <summary>
        /// Style weight between 0 and 1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_weight")]
        public float? StyleWeight { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageStyle" /> class.
        /// </summary>
        /// <param name="styleType">
        /// Style type from the current upstream catalog.
        /// </param>
        /// <param name="styleWeight">
        /// Style weight between 0 and 1.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageStyle(
            string? styleType,
            float? styleWeight)
        {
            this.StyleType = styleType;
            this.StyleWeight = styleWeight;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageStyle" /> class.
        /// </summary>
        public ImageStyle()
        {
        }

    }
}