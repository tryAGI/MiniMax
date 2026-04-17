
#nullable enable

namespace MiniMax
{
    /// <summary>
    /// Reference type (e.g., `character`).
    /// </summary>
    public enum VideoSubjectReferenceType
    {
        /// <summary>
        /// 
        /// </summary>
        Character,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoSubjectReferenceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoSubjectReferenceType value)
        {
            return value switch
            {
                VideoSubjectReferenceType.Character => "character",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoSubjectReferenceType? ToEnum(string value)
        {
            return value switch
            {
                "character" => VideoSubjectReferenceType.Character,
                _ => null,
            };
        }
    }
}