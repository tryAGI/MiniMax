
#nullable enable

namespace MiniMax
{
    /// <summary>
    /// Output format — `hex` returns hex-encoded bytes inline, `url` returns a downloadable link.<br/>
    /// Default Value: hex
    /// </summary>
    public enum MusicGenerationRequestOutputFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Hex,
        /// <summary>
        /// 
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MusicGenerationRequestOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MusicGenerationRequestOutputFormat value)
        {
            return value switch
            {
                MusicGenerationRequestOutputFormat.Hex => "hex",
                MusicGenerationRequestOutputFormat.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MusicGenerationRequestOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "hex" => MusicGenerationRequestOutputFormat.Hex,
                "url" => MusicGenerationRequestOutputFormat.Url,
                _ => null,
            };
        }
    }
}