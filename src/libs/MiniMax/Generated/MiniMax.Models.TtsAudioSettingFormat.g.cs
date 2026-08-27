
#nullable enable

namespace MiniMax
{
    /// <summary>
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
                TtsAudioSettingFormat.Opus => "opus",
                TtsAudioSettingFormat.Pcm => "pcm",
                TtsAudioSettingFormat.PcmuRaw => "pcmu_raw",
                TtsAudioSettingFormat.PcmuWav => "pcmu_wav",
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
                "opus" => TtsAudioSettingFormat.Opus,
                "pcm" => TtsAudioSettingFormat.Pcm,
                "pcmu_raw" => TtsAudioSettingFormat.PcmuRaw,
                "pcmu_wav" => TtsAudioSettingFormat.PcmuWav,
                "wav" => TtsAudioSettingFormat.Wav,
                _ => null,
            };
        }
    }
}