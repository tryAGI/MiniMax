
#nullable enable

namespace MiniMax
{
    /// <summary>
    /// Output resolution.
    /// </summary>
    public enum VideoGenerationRequestResolution
    {
        /// <summary>
        /// 
        /// </summary>
        x1080p,
        /// <summary>
        /// 
        /// </summary>
        x512p,
        /// <summary>
        /// 
        /// </summary>
        x768p,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoGenerationRequestResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoGenerationRequestResolution value)
        {
            return value switch
            {
                VideoGenerationRequestResolution.x1080p => "1080P",
                VideoGenerationRequestResolution.x512p => "512P",
                VideoGenerationRequestResolution.x768p => "768P",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoGenerationRequestResolution? ToEnum(string value)
        {
            return value switch
            {
                "1080P" => VideoGenerationRequestResolution.x1080p,
                "512P" => VideoGenerationRequestResolution.x512p,
                "768P" => VideoGenerationRequestResolution.x768p,
                _ => null,
            };
        }
    }
}