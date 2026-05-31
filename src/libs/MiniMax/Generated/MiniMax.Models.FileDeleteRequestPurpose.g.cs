
#nullable enable

namespace MiniMax
{
    /// <summary>
    /// 
    /// </summary>
    public enum FileDeleteRequestPurpose
    {
        /// <summary>
        /// 
        /// </summary>
        PromptAudio,
        /// <summary>
        /// 
        /// </summary>
        T2aAsync,
        /// <summary>
        /// 
        /// </summary>
        T2aAsyncInput,
        /// <summary>
        /// 
        /// </summary>
        VideoGeneration,
        /// <summary>
        /// 
        /// </summary>
        VoiceClone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FileDeleteRequestPurposeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileDeleteRequestPurpose value)
        {
            return value switch
            {
                FileDeleteRequestPurpose.PromptAudio => "prompt_audio",
                FileDeleteRequestPurpose.T2aAsync => "t2a_async",
                FileDeleteRequestPurpose.T2aAsyncInput => "t2a_async_input",
                FileDeleteRequestPurpose.VideoGeneration => "video_generation",
                FileDeleteRequestPurpose.VoiceClone => "voice_clone",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileDeleteRequestPurpose? ToEnum(string value)
        {
            return value switch
            {
                "prompt_audio" => FileDeleteRequestPurpose.PromptAudio,
                "t2a_async" => FileDeleteRequestPurpose.T2aAsync,
                "t2a_async_input" => FileDeleteRequestPurpose.T2aAsyncInput,
                "video_generation" => FileDeleteRequestPurpose.VideoGeneration,
                "voice_clone" => FileDeleteRequestPurpose.VoiceClone,
                _ => null,
            };
        }
    }
}