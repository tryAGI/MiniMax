
#nullable enable

namespace MiniMax
{
    /// <summary>
    /// Task lifecycle status.
    /// </summary>
    public enum VideoTaskStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Fail,
        /// <summary>
        /// 
        /// </summary>
        Preparing,
        /// <summary>
        /// 
        /// </summary>
        Processing,
        /// <summary>
        /// 
        /// </summary>
        Queueing,
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoTaskStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoTaskStatus value)
        {
            return value switch
            {
                VideoTaskStatus.Fail => "Fail",
                VideoTaskStatus.Preparing => "Preparing",
                VideoTaskStatus.Processing => "Processing",
                VideoTaskStatus.Queueing => "Queueing",
                VideoTaskStatus.Success => "Success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoTaskStatus? ToEnum(string value)
        {
            return value switch
            {
                "Fail" => VideoTaskStatus.Fail,
                "Preparing" => VideoTaskStatus.Preparing,
                "Processing" => VideoTaskStatus.Processing,
                "Queueing" => VideoTaskStatus.Queueing,
                "Success" => VideoTaskStatus.Success,
                _ => null,
            };
        }
    }
}