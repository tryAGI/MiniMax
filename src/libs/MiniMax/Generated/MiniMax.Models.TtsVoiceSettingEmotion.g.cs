
#nullable enable

namespace MiniMax
{
    /// <summary>
    /// Emotional tone.
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
        Happy,
        /// <summary>
        /// 
        /// </summary>
        Neutral,
        /// <summary>
        /// 
        /// </summary>
        Sad,
        /// <summary>
        /// 
        /// </summary>
        Surprised,
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
                TtsVoiceSettingEmotion.Happy => "happy",
                TtsVoiceSettingEmotion.Neutral => "neutral",
                TtsVoiceSettingEmotion.Sad => "sad",
                TtsVoiceSettingEmotion.Surprised => "surprised",
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
                "happy" => TtsVoiceSettingEmotion.Happy,
                "neutral" => TtsVoiceSettingEmotion.Neutral,
                "sad" => TtsVoiceSettingEmotion.Sad,
                "surprised" => TtsVoiceSettingEmotion.Surprised,
                _ => null,
            };
        }
    }
}