
#nullable enable

namespace MiniMax
{
    /// <summary>
    /// Video template task state.
    /// </summary>
    public enum VideoTemplateTaskStatus
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
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoTemplateTaskStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoTemplateTaskStatus value)
        {
            return value switch
            {
                VideoTemplateTaskStatus.Fail => "Fail",
                VideoTemplateTaskStatus.Preparing => "Preparing",
                VideoTemplateTaskStatus.Processing => "Processing",
                VideoTemplateTaskStatus.Success => "Success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoTemplateTaskStatus? ToEnum(string value)
        {
            return value switch
            {
                "Fail" => VideoTemplateTaskStatus.Fail,
                "Preparing" => VideoTemplateTaskStatus.Preparing,
                "Processing" => VideoTemplateTaskStatus.Processing,
                "Success" => VideoTemplateTaskStatus.Success,
                _ => null,
            };
        }
    }
}