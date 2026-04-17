
#nullable enable

namespace MiniMax
{
    /// <summary>
    /// Preset sound effect.
    /// </summary>
    public enum TtsVoiceModifySoundEffects
    {
        /// <summary>
        /// 
        /// </summary>
        AuditoriumEcho,
        /// <summary>
        /// 
        /// </summary>
        LofiTelephone,
        /// <summary>
        /// 
        /// </summary>
        Robotic,
        /// <summary>
        /// 
        /// </summary>
        SpaciousEcho,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TtsVoiceModifySoundEffectsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsVoiceModifySoundEffects value)
        {
            return value switch
            {
                TtsVoiceModifySoundEffects.AuditoriumEcho => "auditorium_echo",
                TtsVoiceModifySoundEffects.LofiTelephone => "lofi_telephone",
                TtsVoiceModifySoundEffects.Robotic => "robotic",
                TtsVoiceModifySoundEffects.SpaciousEcho => "spacious_echo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsVoiceModifySoundEffects? ToEnum(string value)
        {
            return value switch
            {
                "auditorium_echo" => TtsVoiceModifySoundEffects.AuditoriumEcho,
                "lofi_telephone" => TtsVoiceModifySoundEffects.LofiTelephone,
                "robotic" => TtsVoiceModifySoundEffects.Robotic,
                "spacious_echo" => TtsVoiceModifySoundEffects.SpaciousEcho,
                _ => null,
            };
        }
    }
}