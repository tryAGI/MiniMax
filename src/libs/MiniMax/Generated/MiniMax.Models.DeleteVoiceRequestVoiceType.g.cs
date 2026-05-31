
#nullable enable

namespace MiniMax
{
    /// <summary>
    /// 
    /// </summary>
    public enum DeleteVoiceRequestVoiceType
    {
        /// <summary>
        /// 
        /// </summary>
        VoiceCloning,
        /// <summary>
        /// 
        /// </summary>
        VoiceGeneration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeleteVoiceRequestVoiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteVoiceRequestVoiceType value)
        {
            return value switch
            {
                DeleteVoiceRequestVoiceType.VoiceCloning => "voice_cloning",
                DeleteVoiceRequestVoiceType.VoiceGeneration => "voice_generation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteVoiceRequestVoiceType? ToEnum(string value)
        {
            return value switch
            {
                "voice_cloning" => DeleteVoiceRequestVoiceType.VoiceCloning,
                "voice_generation" => DeleteVoiceRequestVoiceType.VoiceGeneration,
                _ => null,
            };
        }
    }
}