
#nullable enable

namespace MiniMax
{
    /// <summary>
    /// Voice effect/modulation settings.
    /// </summary>
    public sealed partial class TtsVoiceModify
    {
        /// <summary>
        /// Pitch adjustment, -100 to 100.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pitch")]
        public int? Pitch { get; set; }

        /// <summary>
        /// Intensity adjustment, -100 to 100.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("intensity")]
        public int? Intensity { get; set; }

        /// <summary>
        /// Timbre adjustment, -100 to 100.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timbre")]
        public int? Timbre { get; set; }

        /// <summary>
        /// Preset sound effect.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sound_effects")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MiniMax.JsonConverters.TtsVoiceModifySoundEffectsJsonConverter))]
        public global::MiniMax.TtsVoiceModifySoundEffects? SoundEffects { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsVoiceModify" /> class.
        /// </summary>
        /// <param name="pitch">
        /// Pitch adjustment, -100 to 100.
        /// </param>
        /// <param name="intensity">
        /// Intensity adjustment, -100 to 100.
        /// </param>
        /// <param name="timbre">
        /// Timbre adjustment, -100 to 100.
        /// </param>
        /// <param name="soundEffects">
        /// Preset sound effect.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsVoiceModify(
            int? pitch,
            int? intensity,
            int? timbre,
            global::MiniMax.TtsVoiceModifySoundEffects? soundEffects)
        {
            this.Pitch = pitch;
            this.Intensity = intensity;
            this.Timbre = timbre;
            this.SoundEffects = soundEffects;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsVoiceModify" /> class.
        /// </summary>
        public TtsVoiceModify()
        {
        }
    }
}