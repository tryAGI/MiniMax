
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace MiniMax
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.BaseResponse? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.ImageStyle? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public float? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.ImageSubjectReference? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.ImageSubjectReferenceType? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.ImageGenerationData? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.ImageGenerationMetadata? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.OneOf<int?, string>? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.ImageGenerationRequest? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::MiniMax.ImageSubjectReference>? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.ImageGenerationRequestAspectRatio? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.ImageGenerationRequestResponseFormat? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.ImageGenerationResponse? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.VideoSubjectReference? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.VideoSubjectReferenceType? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.VideoGenerationRequest? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::MiniMax.VideoSubjectReference>? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.VideoGenerationRequestResolution? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.VideoGenerationResponse? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.VideoTaskStatus? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.VideoTaskStatusResponse? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.VideoTemplateTextInput? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.VideoTemplateMediaInput? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.VideoTemplateGenerationRequest? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::MiniMax.VideoTemplateTextInput>? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::MiniMax.VideoTemplateMediaInput>? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.VideoTemplateGenerationResponse? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.VideoTemplateTaskStatus? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.VideoTemplateTaskStatusResponse? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.MusicAudioSetting? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.MusicAudioSettingFormat? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.MusicGenerationRequest? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.MusicGenerationRequestOutputFormat? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.MusicGenerationData? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.MusicGenerationExtraInfo? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.MusicGenerationResponse? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.MusicCoverPreprocessRequest? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.MusicCoverPreprocessResponse? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.LyricsGenerationRequest? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.LyricsGenerationRequestMode? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.LyricsGenerationResponse? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.TtsVoiceSetting? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.TtsVoiceSettingEmotion? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.TtsAudioSetting? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.TtsAudioSettingFormat? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.TtsPronunciationDict? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.TtsVoiceModify? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.TtsVoiceModifySoundEffects? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.TtsStreamOptions? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.TimberWeight? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.TextToSpeechRequest? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::MiniMax.TimberWeight>? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.TextToSpeechRequestLanguageBoost? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.TextToSpeechRequestSubtitleType? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.TextToSpeechRequestOutputFormat? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.TtsData? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.TtsExtraInfo? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.TtsExtraInfoAudioFormat? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.TextToSpeechResponse? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.AsyncTextToSpeechVoiceSetting? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.AsyncTextToSpeechVoiceSettingEmotion? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.AsyncTextToSpeechAudioSetting? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.AsyncTextToSpeechAudioSettingFormat? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.AsyncTextToSpeechPronunciationDict? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.AsyncTextToSpeechRequest? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.AsyncTextToSpeechRequestLanguageBoost? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.AsyncTextToSpeechTaskResponse? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.AsyncTextToSpeechTaskStatus? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.AsyncTextToSpeechTaskStatusResponse? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.VoiceClonePrompt? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.VoiceCloneExtraInfo? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.VoiceCloneRequest? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.VoiceCloneRequestLanguageBoost? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.VoiceCloneResponse? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.VoiceDesignRequest? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.VoiceDesignResponse? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.GetVoicesRequest? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.GetVoicesRequestVoiceType? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.SystemVoiceInfo? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.VoiceCloningInfo? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.VoiceGenerationInfo? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.GetVoicesResponse? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::MiniMax.SystemVoiceInfo>? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::MiniMax.VoiceCloningInfo>? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::MiniMax.VoiceGenerationInfo>? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.DeleteVoiceRequest? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.DeleteVoiceRequestVoiceType? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.DeleteVoiceResponse? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.FileUploadRequest? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.FileUploadRequestPurpose? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.FileInfo? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.FileUploadResponse? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.FileRetrieveResponse? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.FileListResponse? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::MiniMax.FileInfo>? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.FileDeleteRequest? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.FileDeleteRequestPurpose? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MiniMax.FileDeleteResponse? Type104 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::MiniMax.ImageSubjectReference>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::MiniMax.VideoSubjectReference>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::MiniMax.VideoTemplateTextInput>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::MiniMax.VideoTemplateMediaInput>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::MiniMax.TimberWeight>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::MiniMax.SystemVoiceInfo>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::MiniMax.VoiceCloningInfo>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::MiniMax.VoiceGenerationInfo>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::MiniMax.FileInfo>? ListType9 { get; set; }
    }
}