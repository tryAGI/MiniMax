
#nullable enable

namespace MiniMax
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MusicCoverPreprocessResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cover_feature_id")]
        public string? CoverFeatureId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("formatted_lyrics")]
        public string? FormattedLyrics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("structure_result")]
        public string? StructureResult { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_duration")]
        public double? AudioDuration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_id")]
        public string? TraceId { get; set; }

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
        /// Initializes a new instance of the <see cref="MusicCoverPreprocessResponse" /> class.
        /// </summary>
        /// <param name="coverFeatureId"></param>
        /// <param name="formattedLyrics"></param>
        /// <param name="structureResult"></param>
        /// <param name="audioDuration"></param>
        /// <param name="traceId"></param>
        /// <param name="baseResp">
        /// Common status envelope returned by MiniMax API calls.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MusicCoverPreprocessResponse(
            string? coverFeatureId,
            string? formattedLyrics,
            string? structureResult,
            double? audioDuration,
            string? traceId,
            global::MiniMax.BaseResponse? baseResp)
        {
            this.CoverFeatureId = coverFeatureId;
            this.FormattedLyrics = formattedLyrics;
            this.StructureResult = structureResult;
            this.AudioDuration = audioDuration;
            this.TraceId = traceId;
            this.BaseResp = baseResp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MusicCoverPreprocessResponse" /> class.
        /// </summary>
        public MusicCoverPreprocessResponse()
        {
        }

    }
}