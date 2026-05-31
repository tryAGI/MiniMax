
#nullable enable

namespace MiniMax
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageGenerationResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::MiniMax.ImageGenerationData? Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::MiniMax.ImageGenerationMetadata? Metadata { get; set; }

        /// <summary>
        /// Generation request ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Common status envelope returned by MiniMax API calls.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_resp")]
        public global::MiniMax.BaseResponse? BaseResp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="metadata"></param>
        /// <param name="id">
        /// Generation request ID.
        /// </param>
        /// <param name="baseResp">
        /// Common status envelope returned by MiniMax API calls.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageGenerationResponse(
            global::MiniMax.ImageGenerationData? data,
            global::MiniMax.ImageGenerationMetadata? metadata,
            string? id,
            global::MiniMax.BaseResponse? baseResp)
        {
            this.Data = data;
            this.Metadata = metadata;
            this.Id = id;
            this.BaseResp = baseResp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationResponse" /> class.
        /// </summary>
        public ImageGenerationResponse()
        {
        }

    }
}