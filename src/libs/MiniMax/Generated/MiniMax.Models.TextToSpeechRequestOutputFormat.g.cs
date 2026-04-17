
#nullable enable

namespace MiniMax
{
    /// <summary>
    /// Output format (non-streaming only).<br/>
    /// Default Value: hex
    /// </summary>
    public enum TextToSpeechRequestOutputFormat
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
    public static class TextToSpeechRequestOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextToSpeechRequestOutputFormat value)
        {
            return value switch
            {
                TextToSpeechRequestOutputFormat.Hex => "hex",
                TextToSpeechRequestOutputFormat.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextToSpeechRequestOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "hex" => TextToSpeechRequestOutputFormat.Hex,
                "url" => TextToSpeechRequestOutputFormat.Url,
                _ => null,
            };
        }
    }
}