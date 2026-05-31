
#nullable enable

namespace MiniMax
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetVoicesRequestVoiceType
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        System,
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
    public static class GetVoicesRequestVoiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetVoicesRequestVoiceType value)
        {
            return value switch
            {
                GetVoicesRequestVoiceType.All => "all",
                GetVoicesRequestVoiceType.System => "system",
                GetVoicesRequestVoiceType.VoiceCloning => "voice_cloning",
                GetVoicesRequestVoiceType.VoiceGeneration => "voice_generation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetVoicesRequestVoiceType? ToEnum(string value)
        {
            return value switch
            {
                "all" => GetVoicesRequestVoiceType.All,
                "system" => GetVoicesRequestVoiceType.System,
                "voice_cloning" => GetVoicesRequestVoiceType.VoiceCloning,
                "voice_generation" => GetVoicesRequestVoiceType.VoiceGeneration,
                _ => null,
            };
        }
    }
}