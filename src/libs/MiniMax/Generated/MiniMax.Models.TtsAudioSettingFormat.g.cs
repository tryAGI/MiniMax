
#nullable enable

namespace MiniMax
{
    /// <summary>
    /// Output audio format.<br/>
    /// Default Value: mp3
    /// </summary>
    public enum TtsAudioSettingFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Flac,
        /// <summary>
        /// 
        /// </summary>
        Mp3,
        /// <summary>
        /// 
        /// </summary>
        Pcm,
        /// <summary>
        /// 
        /// </summary>
        Wav,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TtsAudioSettingFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsAudioSettingFormat value)
        {
            return value switch
            {
                TtsAudioSettingFormat.Flac => "flac",
                TtsAudioSettingFormat.Mp3 => "mp3",
                TtsAudioSettingFormat.Pcm => "pcm",
                TtsAudioSettingFormat.Wav => "wav",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsAudioSettingFormat? ToEnum(string value)
        {
            return value switch
            {
                "flac" => TtsAudioSettingFormat.Flac,
                "mp3" => TtsAudioSettingFormat.Mp3,
                "pcm" => TtsAudioSettingFormat.Pcm,
                "wav" => TtsAudioSettingFormat.Wav,
                _ => null,
            };
        }
    }
}