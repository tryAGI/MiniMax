
#nullable enable

namespace MiniMax
{
    /// <summary>
    /// Default Value: sentence
    /// </summary>
    public enum TextToSpeechRequestSubtitleType
    {
        /// <summary>
        ///
        /// </summary>
        Sentence,
        /// <summary>
        ///
        /// </summary>
        Word,
        /// <summary>
        ///
        /// </summary>
        WordStreaming,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextToSpeechRequestSubtitleTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextToSpeechRequestSubtitleType value)
        {
            return value switch
            {
                TextToSpeechRequestSubtitleType.Sentence => "sentence",
                TextToSpeechRequestSubtitleType.Word => "word",
                TextToSpeechRequestSubtitleType.WordStreaming => "word_streaming",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextToSpeechRequestSubtitleType? ToEnum(string value)
        {
            return value switch
            {
                "sentence" => TextToSpeechRequestSubtitleType.Sentence,
                "word" => TextToSpeechRequestSubtitleType.Word,
                "word_streaming" => TextToSpeechRequestSubtitleType.WordStreaming,
                _ => null,
            };
        }
    }
}