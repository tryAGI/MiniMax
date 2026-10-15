
#nullable enable

namespace MiniMax
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ImageGenerationMetadata
    {
        /// <summary>
        /// Returned as a string by the API; numeric schema retained for clients that emit numbers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success_count")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MiniMax.JsonConverters.OneOfJsonConverter<int?, string>))]
        public global::MiniMax.OneOf<int?, string>? SuccessCount { get; set; }

        /// <summary>
        /// Returned as a string by the API; numeric schema retained for clients that emit numbers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed_count")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MiniMax.JsonConverters.OneOfJsonConverter<int?, string>))]
        public global::MiniMax.OneOf<int?, string>? FailedCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationMetadata" /> class.
        /// </summary>
        /// <param name="successCount">
        /// Returned as a string by the API; numeric schema retained for clients that emit numbers.
        /// </param>
        /// <param name="failedCount">
        /// Returned as a string by the API; numeric schema retained for clients that emit numbers.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageGenerationMetadata(
            global::MiniMax.OneOf<int?, string>? successCount,
            global::MiniMax.OneOf<int?, string>? failedCount)
        {
            this.SuccessCount = successCount;
            this.FailedCount = failedCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationMetadata" /> class.
        /// </summary>
        public ImageGenerationMetadata()
        {
        }

    }
}