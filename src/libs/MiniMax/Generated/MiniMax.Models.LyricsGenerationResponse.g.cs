
#nullable enable

namespace MiniMax
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LyricsGenerationResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("song_title")]
        public string? SongTitle { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_tags")]
        public string? StyleTags { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lyrics")]
        public string? Lyrics { get; set; }

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
        /// Initializes a new instance of the <see cref="LyricsGenerationResponse" /> class.
        /// </summary>
        /// <param name="songTitle"></param>
        /// <param name="styleTags"></param>
        /// <param name="lyrics"></param>
        /// <param name="baseResp">
        /// Common status envelope returned by MiniMax API calls.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LyricsGenerationResponse(
            string? songTitle,
            string? styleTags,
            string? lyrics,
            global::MiniMax.BaseResponse? baseResp)
        {
            this.SongTitle = songTitle;
            this.StyleTags = styleTags;
            this.Lyrics = lyrics;
            this.BaseResp = baseResp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LyricsGenerationResponse" /> class.
        /// </summary>
        public LyricsGenerationResponse()
        {
        }

    }
}