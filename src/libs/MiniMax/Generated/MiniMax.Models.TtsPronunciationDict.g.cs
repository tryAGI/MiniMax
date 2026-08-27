
#nullable enable

namespace MiniMax
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TtsPronunciationDict
    {
        /// <summary>
        /// Pronunciation replacement rules.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tone")]
        public global::System.Collections.Generic.IList<string>? Tone { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsPronunciationDict" /> class.
        /// </summary>
        /// <param name="tone">
        /// Pronunciation replacement rules.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsPronunciationDict(
            global::System.Collections.Generic.IList<string>? tone)
        {
            this.Tone = tone;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsPronunciationDict" /> class.
        /// </summary>
        public TtsPronunciationDict()
        {
        }

    }
}