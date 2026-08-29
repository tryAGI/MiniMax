
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
            typeof(global::MiniMax.JsonConverters.ImageSubjectReferenceTypeJsonConverter),

            typeof(global::MiniMax.JsonConverters.ImageSubjectReferenceTypeNullableJsonConverter),

            typeof(global::MiniMax.JsonConverters.ImageGenerationRequestAspectRatioJsonConverter),

            typeof(global::MiniMax.JsonConverters.ImageGenerationRequestAspectRatioNullableJsonConverter),

            typeof(global::MiniMax.JsonConverters.ImageGenerationRequestResponseFormatJsonConverter),

            typeof(global::MiniMax.JsonConverters.ImageGenerationRequestResponseFormatNullableJsonConverter),

            typeof(global::MiniMax.JsonConverters.VideoSubjectReferenceTypeJsonConverter),

            typeof(global::MiniMax.JsonConverters.VideoSubjectReferenceTypeNullableJsonConverter),

            typeof(global::MiniMax.JsonConverters.VideoGenerationRequestResolutionJsonConverter),

            typeof(global::MiniMax.JsonConverters.VideoGenerationRequestResolutionNullableJsonConverter),

            typeof(global::MiniMax.JsonConverters.VideoTaskStatusJsonConverter),

            typeof(global::MiniMax.JsonConverters.VideoTaskStatusNullableJsonConverter),

            typeof(global::MiniMax.JsonConverters.VideoTemplateTaskStatusJsonConverter),

            typeof(global::MiniMax.JsonConverters.VideoTemplateTaskStatusNullableJsonConverter),

            typeof(global::MiniMax.JsonConverters.MusicAudioSettingFormatJsonConverter),

            typeof(global::MiniMax.JsonConverters.MusicAudioSettingFormatNullableJsonConverter),

            typeof(global::MiniMax.JsonConverters.MusicGenerationRequestOutputFormatJsonConverter),

            typeof(global::MiniMax.JsonConverters.MusicGenerationRequestOutputFormatNullableJsonConverter),

            typeof(global::MiniMax.JsonConverters.LyricsGenerationRequestModeJsonConverter),

            typeof(global::MiniMax.JsonConverters.LyricsGenerationRequestModeNullableJsonConverter),

            typeof(global::MiniMax.JsonConverters.TtsVoiceSettingEmotionJsonConverter),

            typeof(global::MiniMax.JsonConverters.TtsVoiceSettingEmotionNullableJsonConverter),

            typeof(global::MiniMax.JsonConverters.TtsAudioSettingFormatJsonConverter),

            typeof(global::MiniMax.JsonConverters.TtsAudioSettingFormatNullableJsonConverter),

            typeof(global::MiniMax.JsonConverters.TtsVoiceModifySoundEffectsJsonConverter),

            typeof(global::MiniMax.JsonConverters.TtsVoiceModifySoundEffectsNullableJsonConverter),

            typeof(global::MiniMax.JsonConverters.TextToSpeechRequestLanguageBoostJsonConverter),

            typeof(global::MiniMax.JsonConverters.TextToSpeechRequestLanguageBoostNullableJsonConverter),

            typeof(global::MiniMax.JsonConverters.TextToSpeechRequestSubtitleTypeJsonConverter),

            typeof(global::MiniMax.JsonConverters.TextToSpeechRequestSubtitleTypeNullableJsonConverter),

            typeof(global::MiniMax.JsonConverters.TextToSpeechRequestOutputFormatJsonConverter),

            typeof(global::MiniMax.JsonConverters.TextToSpeechRequestOutputFormatNullableJsonConverter),

            typeof(global::MiniMax.JsonConverters.TtsExtraInfoAudioFormatJsonConverter),

            typeof(global::MiniMax.JsonConverters.TtsExtraInfoAudioFormatNullableJsonConverter),

            typeof(global::MiniMax.JsonConverters.AsyncTextToSpeechVoiceSettingEmotionJsonConverter),

            typeof(global::MiniMax.JsonConverters.AsyncTextToSpeechVoiceSettingEmotionNullableJsonConverter),

            typeof(global::MiniMax.JsonConverters.AsyncTextToSpeechAudioSettingFormatJsonConverter),

            typeof(global::MiniMax.JsonConverters.AsyncTextToSpeechAudioSettingFormatNullableJsonConverter),

            typeof(global::MiniMax.JsonConverters.AsyncTextToSpeechRequestLanguageBoostJsonConverter),

            typeof(global::MiniMax.JsonConverters.AsyncTextToSpeechRequestLanguageBoostNullableJsonConverter),

            typeof(global::MiniMax.JsonConverters.AsyncTextToSpeechTaskStatusJsonConverter),

            typeof(global::MiniMax.JsonConverters.AsyncTextToSpeechTaskStatusNullableJsonConverter),

            typeof(global::MiniMax.JsonConverters.VoiceCloneRequestLanguageBoostJsonConverter),

            typeof(global::MiniMax.JsonConverters.VoiceCloneRequestLanguageBoostNullableJsonConverter),

            typeof(global::MiniMax.JsonConverters.GetVoicesRequestVoiceTypeJsonConverter),

            typeof(global::MiniMax.JsonConverters.GetVoicesRequestVoiceTypeNullableJsonConverter),

            typeof(global::MiniMax.JsonConverters.DeleteVoiceRequestVoiceTypeJsonConverter),

            typeof(global::MiniMax.JsonConverters.DeleteVoiceRequestVoiceTypeNullableJsonConverter),

            typeof(global::MiniMax.JsonConverters.FileUploadRequestPurposeJsonConverter),

            typeof(global::MiniMax.JsonConverters.FileUploadRequestPurposeNullableJsonConverter),

            typeof(global::MiniMax.JsonConverters.FileDeleteRequestPurposeJsonConverter),

            typeof(global::MiniMax.JsonConverters.FileDeleteRequestPurposeNullableJsonConverter),

            typeof(global::MiniMax.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.BaseResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.ImageStyle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.ImageSubjectReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.ImageSubjectReferenceType), TypeInfoPropertyName = "ImageSubjectReferenceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.ImageGenerationData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.ImageGenerationMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.ImageGenerationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::MiniMax.ImageSubjectReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.ImageGenerationRequestAspectRatio), TypeInfoPropertyName = "ImageGenerationRequestAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.ImageGenerationRequestResponseFormat), TypeInfoPropertyName = "ImageGenerationRequestResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.ImageGenerationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.VideoSubjectReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.VideoSubjectReferenceType), TypeInfoPropertyName = "VideoSubjectReferenceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.VideoGenerationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::MiniMax.VideoSubjectReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.VideoGenerationRequestResolution), TypeInfoPropertyName = "VideoGenerationRequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.VideoGenerationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.VideoTaskStatus), TypeInfoPropertyName = "VideoTaskStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.VideoTaskStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.VideoTemplateTextInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.VideoTemplateMediaInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.VideoTemplateGenerationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::MiniMax.VideoTemplateTextInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::MiniMax.VideoTemplateMediaInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.VideoTemplateGenerationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.VideoTemplateTaskStatus), TypeInfoPropertyName = "VideoTemplateTaskStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.VideoTemplateTaskStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.MusicAudioSetting))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.MusicAudioSettingFormat), TypeInfoPropertyName = "MusicAudioSettingFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.MusicGenerationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.MusicGenerationRequestOutputFormat), TypeInfoPropertyName = "MusicGenerationRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.MusicGenerationData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.MusicGenerationExtraInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.MusicGenerationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.MusicCoverPreprocessRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.MusicCoverPreprocessResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.LyricsGenerationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.LyricsGenerationRequestMode), TypeInfoPropertyName = "LyricsGenerationRequestMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.LyricsGenerationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.TtsVoiceSetting))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.TextToSpeechRequestLanguageBoost), TypeInfoPropertyName = "TextToSpeechRequestLanguageBoost2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.TextToSpeechRequestSubtitleType), TypeInfoPropertyName = "TextToSpeechRequestSubtitleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.TextToSpeechRequestOutputFormat), TypeInfoPropertyName = "TextToSpeechRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.TtsData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.TtsExtraInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.TtsExtraInfoAudioFormat), TypeInfoPropertyName = "TtsExtraInfoAudioFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.TextToSpeechResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.AsyncTextToSpeechVoiceSetting))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.AsyncTextToSpeechVoiceSettingEmotion), TypeInfoPropertyName = "AsyncTextToSpeechVoiceSettingEmotion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.AsyncTextToSpeechAudioSetting))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.AsyncTextToSpeechAudioSettingFormat), TypeInfoPropertyName = "AsyncTextToSpeechAudioSettingFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.AsyncTextToSpeechPronunciationDict))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.AsyncTextToSpeechRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.AsyncTextToSpeechRequestLanguageBoost), TypeInfoPropertyName = "AsyncTextToSpeechRequestLanguageBoost2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.AsyncTextToSpeechTaskResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.AsyncTextToSpeechTaskStatus), TypeInfoPropertyName = "AsyncTextToSpeechTaskStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.AsyncTextToSpeechTaskStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.VoiceClonePrompt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.VoiceCloneExtraInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.VoiceCloneRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.VoiceCloneRequestLanguageBoost), TypeInfoPropertyName = "VoiceCloneRequestLanguageBoost2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.VoiceCloneResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.VoiceDesignRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.VoiceDesignResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.GetVoicesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.GetVoicesRequestVoiceType), TypeInfoPropertyName = "GetVoicesRequestVoiceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.SystemVoiceInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.VoiceCloningInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.VoiceGenerationInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.GetVoicesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::MiniMax.SystemVoiceInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::MiniMax.VoiceCloningInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::MiniMax.VoiceGenerationInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.DeleteVoiceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.DeleteVoiceRequestVoiceType), TypeInfoPropertyName = "DeleteVoiceRequestVoiceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.DeleteVoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.FileUploadRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.FileUploadRequestPurpose), TypeInfoPropertyName = "FileUploadRequestPurpose2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.FileInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.FileUploadResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.FileRetrieveResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.FileListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::MiniMax.FileInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.FileDeleteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.FileDeleteRequestPurpose), TypeInfoPropertyName = "FileDeleteRequestPurpose2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.FileDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::MiniMax.ImageSubjectReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::MiniMax.VideoSubjectReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::MiniMax.VideoTemplateTextInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::MiniMax.VideoTemplateMediaInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::MiniMax.TimberWeight>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::MiniMax.SystemVoiceInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::MiniMax.VoiceCloningInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::MiniMax.VoiceGenerationInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::MiniMax.FileInfo>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}