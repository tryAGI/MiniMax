
#nullable enable

namespace MiniMax
{
    /// <summary>
    /// Reference prompt-audio pair used to refine the cloned voice.
    /// </summary>
    public sealed partial class VoiceClonePrompt
    {
        /// <summary>
        /// File ID of a previously uploaded prompt-audio file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_audio")]
        public string? PromptAudio { get; set; }

        /// <summary>
        /// Transcript of the prompt audio.
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
        /// File ID of a previously uploaded prompt-audio file.
        /// </param>
        /// <param name="promptText">
        /// Transcript of the prompt audio.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceClonePrompt(
            string? promptAudio,
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