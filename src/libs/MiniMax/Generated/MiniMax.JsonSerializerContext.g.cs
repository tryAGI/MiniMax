
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace MiniMax
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::MiniMax.JsonConverters.VideoSubjectReferenceTypeJsonConverter),

            typeof(global::MiniMax.JsonConverters.VideoSubjectReferenceTypeNullableJsonConverter),

            typeof(global::MiniMax.JsonConverters.VideoGenerationRequestResolutionJsonConverter),

            typeof(global::MiniMax.JsonConverters.VideoGenerationRequestResolutionNullableJsonConverter),

            typeof(global::MiniMax.JsonConverters.VideoTaskStatusJsonConverter),

            typeof(global::MiniMax.JsonConverters.VideoTaskStatusNullableJsonConverter),

            typeof(global::MiniMax.JsonConverters.MusicAudioSettingFormatJsonConverter),

            typeof(global::MiniMax.JsonConverters.MusicAudioSettingFormatNullableJsonConverter),

            typeof(global::MiniMax.JsonConverters.MusicGenerationRequestOutputFormatJsonConverter),

            typeof(global::MiniMax.JsonConverters.MusicGenerationRequestOutputFormatNullableJsonConverter),

            typeof(global::MiniMax.JsonConverters.TtsVoiceSettingEmotionJsonConverter),

            typeof(global::MiniMax.JsonConverters.TtsVoiceSettingEmotionNullableJsonConverter),

            typeof(global::MiniMax.JsonConverters.TtsAudioSettingFormatJsonConverter),

            typeof(global::MiniMax.JsonConverters.TtsAudioSettingFormatNullableJsonConverter),

            typeof(global::MiniMax.JsonConverters.TtsVoiceModifySoundEffectsJsonConverter),

            typeof(global::MiniMax.JsonConverters.TtsVoiceModifySoundEffectsNullableJsonConverter),

            typeof(global::MiniMax.JsonConverters.TextToSpeechRequestOutputFormatJsonConverter),

            typeof(global::MiniMax.JsonConverters.TextToSpeechRequestOutputFormatNullableJsonConverter),

            typeof(global::MiniMax.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.BaseResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.VideoSubjectReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.VideoSubjectReferenceType), TypeInfoPropertyName = "VideoSubjectReferenceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.VideoGenerationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::MiniMax.VideoSubjectReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.VideoGenerationRequestResolution), TypeInfoPropertyName = "VideoGenerationRequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.VideoGenerationData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.VideoGenerationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.VideoTaskStatus), TypeInfoPropertyName = "VideoTaskStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.VideoTaskStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.MusicAudioSetting))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.MusicAudioSettingFormat), TypeInfoPropertyName = "MusicAudioSettingFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.MusicGenerationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.MusicGenerationRequestOutputFormat), TypeInfoPropertyName = "MusicGenerationRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.MusicGenerationData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.MusicGenerationExtraInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.MusicGenerationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.TtsVoiceSetting))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.TtsVoiceSettingEmotion), TypeInfoPropertyName = "TtsVoiceSettingEmotion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.TtsAudioSetting))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.TtsAudioSettingFormat), TypeInfoPropertyName = "TtsAudioSettingFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.TtsPronunciationDict))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.TtsVoiceModify))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.TtsVoiceModifySoundEffects), TypeInfoPropertyName = "TtsVoiceModifySoundEffects2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.TtsStreamOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.TimberWeight))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.TextToSpeechRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::MiniMax.TimberWeight>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.TextToSpeechRequestOutputFormat), TypeInfoPropertyName = "TextToSpeechRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.TtsExtraInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.TtsData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.TextToSpeechResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.VoiceClonePrompt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.VoiceCloneRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.VoiceCloneResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.FileUploadRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.FileInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.FileUploadResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.FileRetrieveResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.FileListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::MiniMax.FileInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.FileDeleteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.FileDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::MiniMax.VideoSubjectReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::MiniMax.TimberWeight>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::MiniMax.FileInfo>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}