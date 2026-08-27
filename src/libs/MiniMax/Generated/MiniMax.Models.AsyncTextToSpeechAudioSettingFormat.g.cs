
#nullable enable

namespace MiniMax
{
    /// <summary>
    /// Default Value: mp3
    /// </summary>
    public enum AsyncTextToSpeechAudioSettingFormat
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
    public static class AsyncTextToSpeechAudioSettingFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AsyncTextToSpeechAudioSettingFormat value)
        {
            return value switch
            {
                AsyncTextToSpeechAudioSettingFormat.Flac => "flac",
                AsyncTextToSpeechAudioSettingFormat.Mp3 => "mp3",
                AsyncTextToSpeechAudioSettingFormat.Opus => "opus",
                AsyncTextToSpeechAudioSettingFormat.Pcm => "pcm",
                AsyncTextToSpeechAudioSettingFormat.PcmuRaw => "pcmu_raw",
                AsyncTextToSpeechAudioSettingFormat.PcmuWav => "pcmu_wav",
                AsyncTextToSpeechAudioSettingFormat.Wav => "wav",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AsyncTextToSpeechAudioSettingFormat? ToEnum(string value)
        {
            return value switch
            {
                "flac" => AsyncTextToSpeechAudioSettingFormat.Flac,
                "mp3" => AsyncTextToSpeechAudioSettingFormat.Mp3,
                "opus" => AsyncTextToSpeechAudioSettingFormat.Opus,
                "pcm" => AsyncTextToSpeechAudioSettingFormat.Pcm,
                "pcmu_raw" => AsyncTextToSpeechAudioSettingFormat.PcmuRaw,
                "pcmu_wav" => AsyncTextToSpeechAudioSettingFormat.PcmuWav,
                "wav" => AsyncTextToSpeechAudioSettingFormat.Wav,
                _ => null,
            };
        }
    }
}