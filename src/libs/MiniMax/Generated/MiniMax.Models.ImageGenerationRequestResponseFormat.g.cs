
#nullable enable

namespace MiniMax
{
    /// <summary>
    /// How images are returned.<br/>
    /// Default Value: url
    /// </summary>
    public enum ImageGenerationRequestResponseFormat
    {
        /// <summary>
        ///
        /// </summary>
        Base64,
        /// <summary>
        ///
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageGenerationRequestResponseFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageGenerationRequestResponseFormat value)
        {
            return value switch
            {
                ImageGenerationRequestResponseFormat.Base64 => "base64",
                ImageGenerationRequestResponseFormat.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageGenerationRequestResponseFormat? ToEnum(string value)
        {
            return value switch
            {
                "base64" => ImageGenerationRequestResponseFormat.Base64,
                "url" => ImageGenerationRequestResponseFormat.Url,
                _ => null,
            };
        }
    }
}