
#nullable enable

namespace MiniMax
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MusicCoverPreprocessRequest
    {
        /// <summary>
        /// Currently required to be `music-cover`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_url")]
        public string? AudioUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_base64")]
        public string? AudioBase64 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MusicCoverPreprocessRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// Currently required to be `music-cover`.
        /// </param>
        /// <param name="audioUrl"></param>
        /// <param name="audioBase64"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MusicCoverPreprocessRequest(
            string model,
            string? audioUrl,
            string? audioBase64)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.AudioUrl = audioUrl;
            this.AudioBase64 = audioBase64;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MusicCoverPreprocessRequest" /> class.
        /// </summary>
        public MusicCoverPreprocessRequest()
        {
        }

    }
}