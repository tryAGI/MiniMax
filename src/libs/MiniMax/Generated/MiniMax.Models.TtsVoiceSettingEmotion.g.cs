
#nullable enable

namespace MiniMax
{
    /// <summary>
    /// Optional speaking emotion.
    /// </summary>
    public enum TtsVoiceSettingEmotion
    {
        /// <summary>
        ///
        /// </summary>
        Angry,
        /// <summary>
        ///
        /// </summary>
        Calm,
        /// <summary>
        ///
        /// </summary>
        Disgusted,
        /// <summary>
        ///
        /// </summary>
        Fearful,
        /// <summary>
        ///
        /// </summary>
        Fluent,
        /// <summary>
        ///
        /// </summary>
        Happy,
        /// <summary>
        ///
        /// </summary>
        Sad,
        /// <summary>
        ///
        /// </summary>
        Surprised,
        /// <summary>
        ///
        /// </summary>
        Whisper,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TtsVoiceSettingEmotionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsVoiceSettingEmotion value)
        {
            return value switch
            {
                TtsVoiceSettingEmotion.Angry => "angry",
                TtsVoiceSettingEmotion.Calm => "calm",
                TtsVoiceSettingEmotion.Disgusted => "disgusted",
                TtsVoiceSettingEmotion.Fearful => "fearful",
                TtsVoiceSettingEmotion.Fluent => "fluent",
                TtsVoiceSettingEmotion.Happy => "happy",
                TtsVoiceSettingEmotion.Sad => "sad",
                TtsVoiceSettingEmotion.Surprised => "surprised",
                TtsVoiceSettingEmotion.Whisper => "whisper",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsVoiceSettingEmotion? ToEnum(string value)
        {
            return value switch
            {
                "angry" => TtsVoiceSettingEmotion.Angry,
                "calm" => TtsVoiceSettingEmotion.Calm,
                "disgusted" => TtsVoiceSettingEmotion.Disgusted,
                "fearful" => TtsVoiceSettingEmotion.Fearful,
                "fluent" => TtsVoiceSettingEmotion.Fluent,
                "happy" => TtsVoiceSettingEmotion.Happy,
                "sad" => TtsVoiceSettingEmotion.Sad,
                "surprised" => TtsVoiceSettingEmotion.Surprised,
                "whisper" => TtsVoiceSettingEmotion.Whisper,
                _ => null,
            };
        }
    }
}