
#nullable enable

namespace MiniMax
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoiceClonePrompt
    {
        /// <summary>
        /// Uploaded prompt-audio file ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_audio")]
        public long? PromptAudio { get; set; }

        /// <summary>
        /// Transcript for the prompt audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_text")]
        public string? PromptText { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceClonePrompt" /> class.
        /// </summary>
        /// <param name="promptAudio">
        /// Uploaded prompt-audio file ID.
        /// </param>
        /// <param name="promptText">
        /// Transcript for the prompt audio.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceClonePrompt(
            long? promptAudio,
            string? promptText)
        {
            this.PromptAudio = promptAudio;
            this.PromptText = promptText;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceClonePrompt" /> class.
        /// </summary>
        public VoiceClonePrompt()
        {
        }

    }
}