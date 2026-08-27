
#nullable enable

namespace MiniMax
{
    /// <summary>
    /// Reference subject type.
    /// </summary>
    public enum ImageSubjectReferenceType
    {
        /// <summary>
        ///
        /// </summary>
        Character,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageSubjectReferenceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageSubjectReferenceType value)
        {
            return value switch
            {
                ImageSubjectReferenceType.Character => "character",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageSubjectReferenceType? ToEnum(string value)
        {
            return value switch
            {
                "character" => ImageSubjectReferenceType.Character,
                _ => null,
            };
        }
    }
}