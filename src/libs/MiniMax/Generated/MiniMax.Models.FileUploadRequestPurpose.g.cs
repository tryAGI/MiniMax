
#nullable enable

namespace MiniMax
{
    /// <summary>
    /// Upload purpose.
    /// </summary>
    public enum FileUploadRequestPurpose
    {
        /// <summary>
        ///
        /// </summary>
        PromptAudio,
        /// <summary>
        ///
        /// </summary>
        T2aAsyncInput,
        /// <summary>
        ///
        /// </summary>
        VoiceClone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FileUploadRequestPurposeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileUploadRequestPurpose value)
        {
            return value switch
            {
                FileUploadRequestPurpose.PromptAudio => "prompt_audio",
                FileUploadRequestPurpose.T2aAsyncInput => "t2a_async_input",
                FileUploadRequestPurpose.VoiceClone => "voice_clone",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileUploadRequestPurpose? ToEnum(string value)
        {
            return value switch
            {
                "prompt_audio" => FileUploadRequestPurpose.PromptAudio,
                "t2a_async_input" => FileUploadRequestPurpose.T2aAsyncInput,
                "voice_clone" => FileUploadRequestPurpose.VoiceClone,
                _ => null,
            };
        }
    }
}