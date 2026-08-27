
#nullable enable

namespace MiniMax
{
    /// <summary>
    /// Lyrics generation mode.
    /// </summary>
    public enum LyricsGenerationRequestMode
    {
        /// <summary>
        ///
        /// </summary>
        Edit,
        /// <summary>
        ///
        /// </summary>
        WriteFullSong,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LyricsGenerationRequestModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LyricsGenerationRequestMode value)
        {
            return value switch
            {
                LyricsGenerationRequestMode.Edit => "edit",
                LyricsGenerationRequestMode.WriteFullSong => "write_full_song",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LyricsGenerationRequestMode? ToEnum(string value)
        {
            return value switch
            {
                "edit" => LyricsGenerationRequestMode.Edit,
                "write_full_song" => LyricsGenerationRequestMode.WriteFullSong,
                _ => null,
            };
        }
    }
}