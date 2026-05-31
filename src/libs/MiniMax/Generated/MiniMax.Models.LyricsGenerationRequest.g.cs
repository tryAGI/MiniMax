
#nullable enable

namespace MiniMax
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LyricsGenerationRequest
    {
        /// <summary>
        /// Lyrics generation mode.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MiniMax.JsonConverters.LyricsGenerationRequestModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::MiniMax.LyricsGenerationRequestMode Mode { get; set; }

        /// <summary>
        /// Prompt describing the song or rewrite request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Existing lyrics for continuation or rewrite.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lyrics")]
        public string? Lyrics { get; set; }

        /// <summary>
        /// Optional title hint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LyricsGenerationRequest" /> class.
        /// </summary>
        /// <param name="mode">
        /// Lyrics generation mode.
        /// </param>
        /// <param name="prompt">
        /// Prompt describing the song or rewrite request.
        /// </param>
        /// <param name="lyrics">
        /// Existing lyrics for continuation or rewrite.
        /// </param>
        /// <param name="title">
        /// Optional title hint.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LyricsGenerationRequest(
            global::MiniMax.LyricsGenerationRequestMode mode,
            string? prompt,
            string? lyrics,
            string? title)
        {
            this.Mode = mode;
            this.Prompt = prompt;
            this.Lyrics = lyrics;
            this.Title = title;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LyricsGenerationRequest" /> class.
        /// </summary>
        public LyricsGenerationRequest()
        {
        }

    }
}