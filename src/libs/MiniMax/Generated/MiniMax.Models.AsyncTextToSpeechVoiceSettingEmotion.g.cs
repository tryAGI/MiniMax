
#nullable enable

namespace MiniMax
{
    /// <summary>
    ///
    /// </summary>
    public enum AsyncTextToSpeechVoiceSettingEmotion
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
    public static class AsyncTextToSpeechVoiceSettingEmotionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AsyncTextToSpeechVoiceSettingEmotion value)
        {
            return value switch
            {
                AsyncTextToSpeechVoiceSettingEmotion.Angry => "angry",
                AsyncTextToSpeechVoiceSettingEmotion.Calm => "calm",
                AsyncTextToSpeechVoiceSettingEmotion.Disgusted => "disgusted",
                AsyncTextToSpeechVoiceSettingEmotion.Fearful => "fearful",
                AsyncTextToSpeechVoiceSettingEmotion.Fluent => "fluent",
                AsyncTextToSpeechVoiceSettingEmotion.Happy => "happy",
                AsyncTextToSpeechVoiceSettingEmotion.Sad => "sad",
                AsyncTextToSpeechVoiceSettingEmotion.Surprised => "surprised",
                AsyncTextToSpeechVoiceSettingEmotion.Whisper => "whisper",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AsyncTextToSpeechVoiceSettingEmotion? ToEnum(string value)
        {
            return value switch
            {
                "angry" => AsyncTextToSpeechVoiceSettingEmotion.Angry,
                "calm" => AsyncTextToSpeechVoiceSettingEmotion.Calm,
                "disgusted" => AsyncTextToSpeechVoiceSettingEmotion.Disgusted,
                "fearful" => AsyncTextToSpeechVoiceSettingEmotion.Fearful,
                "fluent" => AsyncTextToSpeechVoiceSettingEmotion.Fluent,
                "happy" => AsyncTextToSpeechVoiceSettingEmotion.Happy,
                "sad" => AsyncTextToSpeechVoiceSettingEmotion.Sad,
                "surprised" => AsyncTextToSpeechVoiceSettingEmotion.Surprised,
                "whisper" => AsyncTextToSpeechVoiceSettingEmotion.Whisper,
                _ => null,
            };
        }
    }
}