
#nullable enable

namespace MiniMax
{
    /// <summary>
    ///
    /// </summary>
    public enum AsyncTextToSpeechTaskStatus
    {
        /// <summary>
        ///
        /// </summary>
        Expired,
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        Processing,
        /// <summary>
        ///
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AsyncTextToSpeechTaskStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AsyncTextToSpeechTaskStatus value)
        {
            return value switch
            {
                AsyncTextToSpeechTaskStatus.Expired => "expired",
                AsyncTextToSpeechTaskStatus.Failed => "failed",
                AsyncTextToSpeechTaskStatus.Processing => "processing",
                AsyncTextToSpeechTaskStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AsyncTextToSpeechTaskStatus? ToEnum(string value)
        {
            return value switch
            {
                "expired" => AsyncTextToSpeechTaskStatus.Expired,
                "failed" => AsyncTextToSpeechTaskStatus.Failed,
                "processing" => AsyncTextToSpeechTaskStatus.Processing,
                "success" => AsyncTextToSpeechTaskStatus.Success,
                _ => null,
            };
        }
    }
}