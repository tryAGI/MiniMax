
#nullable enable

namespace MiniMax
{
    /// <summary>
    ///
    /// </summary>
    public enum TtsExtraInfoAudioFormat
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
        Opus,
        /// <summary>
        ///
        /// </summary>
        Pcm,
        /// <summary>
        ///
        /// </summary>
        PcmuRaw,
        /// <summary>
        ///
        /// </summary>
        PcmuWav,
        /// <summary>
        ///
        /// </summary>
        Wav,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TtsExtraInfoAudioFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsExtraInfoAudioFormat value)
        {
            return value switch
            {
                TtsExtraInfoAudioFormat.Flac => "flac",
                TtsExtraInfoAudioFormat.Mp3 => "mp3",
                TtsExtraInfoAudioFormat.Opus => "opus",
                TtsExtraInfoAudioFormat.Pcm => "pcm",
                TtsExtraInfoAudioFormat.PcmuRaw => "pcmu_raw",
                TtsExtraInfoAudioFormat.PcmuWav => "pcmu_wav",
                TtsExtraInfoAudioFormat.Wav => "wav",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsExtraInfoAudioFormat? ToEnum(string value)
        {
            return value switch
            {
                "flac" => TtsExtraInfoAudioFormat.Flac,
                "mp3" => TtsExtraInfoAudioFormat.Mp3,
                "opus" => TtsExtraInfoAudioFormat.Opus,
                "pcm" => TtsExtraInfoAudioFormat.Pcm,
                "pcmu_raw" => TtsExtraInfoAudioFormat.PcmuRaw,
                "pcmu_wav" => TtsExtraInfoAudioFormat.PcmuWav,
                "wav" => TtsExtraInfoAudioFormat.Wav,
                _ => null,
            };
        }
    }
}