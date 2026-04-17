
#nullable enable

namespace MiniMax
{
    /// <summary>
    /// Audio format.
    /// </summary>
    public enum MusicAudioSettingFormat
    {
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
    public static class MusicAudioSettingFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MusicAudioSettingFormat value)
        {
            return value switch
            {
                MusicAudioSettingFormat.Mp3 => "mp3",
                MusicAudioSettingFormat.Pcm => "pcm",
                MusicAudioSettingFormat.Wav => "wav",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MusicAudioSettingFormat? ToEnum(string value)
        {
            return value switch
            {
                "mp3" => MusicAudioSettingFormat.Mp3,
                "pcm" => MusicAudioSettingFormat.Pcm,
                "wav" => MusicAudioSettingFormat.Wav,
                _ => null,
            };
        }
    }
}