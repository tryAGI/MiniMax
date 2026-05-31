
#nullable enable

namespace MiniMax
{
    /// <summary>
    /// 
    /// </summary>
    public enum VoiceCloneRequestLanguageBoost
    {
        /// <summary>
        /// 
        /// </summary>
        Afrikaans,
        /// <summary>
        /// 
        /// </summary>
        Arabic,
        /// <summary>
        /// 
        /// </summary>
        Bulgarian,
        /// <summary>
        /// 
        /// </summary>
        Catalan,
        /// <summary>
        /// 
        /// </summary>
        Chinese,
        /// <summary>
        /// 
        /// </summary>
        Chinese_Yue,
        /// <summary>
        /// 
        /// </summary>
        Croatian,
        /// <summary>
        /// 
        /// </summary>
        Czech,
        /// <summary>
        /// 
        /// </summary>
        Danish,
        /// <summary>
        /// 
        /// </summary>
        Dutch,
        /// <summary>
        /// 
        /// </summary>
        English,
        /// <summary>
        /// 
        /// </summary>
        Filipino,
        /// <summary>
        /// 
        /// </summary>
        Finnish,
        /// <summary>
        /// 
        /// </summary>
        French,
        /// <summary>
        /// 
        /// </summary>
        German,
        /// <summary>
        /// 
        /// </summary>
        Greek,
        /// <summary>
        /// 
        /// </summary>
        Hebrew,
        /// <summary>
        /// 
        /// </summary>
        Hindi,
        /// <summary>
        /// 
        /// </summary>
        Hungarian,
        /// <summary>
        /// 
        /// </summary>
        Indonesian,
        /// <summary>
        /// 
        /// </summary>
        Italian,
        /// <summary>
        /// 
        /// </summary>
        Japanese,
        /// <summary>
        /// 
        /// </summary>
        Korean,
        /// <summary>
        /// 
        /// </summary>
        Malay,
        /// <summary>
        /// 
        /// </summary>
        Norwegian,
        /// <summary>
        /// 
        /// </summary>
        Nynorsk,
        /// <summary>
        /// 
        /// </summary>
        Persian,
        /// <summary>
        /// 
        /// </summary>
        Polish,
        /// <summary>
        /// 
        /// </summary>
        Portuguese,
        /// <summary>
        /// 
        /// </summary>
        Romanian,
        /// <summary>
        /// 
        /// </summary>
        Russian,
        /// <summary>
        /// 
        /// </summary>
        Slovak,
        /// <summary>
        /// 
        /// </summary>
        Slovenian,
        /// <summary>
        /// 
        /// </summary>
        Spanish,
        /// <summary>
        /// 
        /// </summary>
        Swedish,
        /// <summary>
        /// 
        /// </summary>
        Tamil,
        /// <summary>
        /// 
        /// </summary>
        Thai,
        /// <summary>
        /// 
        /// </summary>
        Turkish,
        /// <summary>
        /// 
        /// </summary>
        Ukrainian,
        /// <summary>
        /// 
        /// </summary>
        Vietnamese,
        /// <summary>
        /// 
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoiceCloneRequestLanguageBoostExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceCloneRequestLanguageBoost value)
        {
            return value switch
            {
                VoiceCloneRequestLanguageBoost.Afrikaans => "Afrikaans",
                VoiceCloneRequestLanguageBoost.Arabic => "Arabic",
                VoiceCloneRequestLanguageBoost.Bulgarian => "Bulgarian",
                VoiceCloneRequestLanguageBoost.Catalan => "Catalan",
                VoiceCloneRequestLanguageBoost.Chinese => "Chinese",
                VoiceCloneRequestLanguageBoost.Chinese_Yue => "Chinese,Yue",
                VoiceCloneRequestLanguageBoost.Croatian => "Croatian",
                VoiceCloneRequestLanguageBoost.Czech => "Czech",
                VoiceCloneRequestLanguageBoost.Danish => "Danish",
                VoiceCloneRequestLanguageBoost.Dutch => "Dutch",
                VoiceCloneRequestLanguageBoost.English => "English",
                VoiceCloneRequestLanguageBoost.Filipino => "Filipino",
                VoiceCloneRequestLanguageBoost.Finnish => "Finnish",
                VoiceCloneRequestLanguageBoost.French => "French",
                VoiceCloneRequestLanguageBoost.German => "German",
                VoiceCloneRequestLanguageBoost.Greek => "Greek",
                VoiceCloneRequestLanguageBoost.Hebrew => "Hebrew",
                VoiceCloneRequestLanguageBoost.Hindi => "Hindi",
                VoiceCloneRequestLanguageBoost.Hungarian => "Hungarian",
                VoiceCloneRequestLanguageBoost.Indonesian => "Indonesian",
                VoiceCloneRequestLanguageBoost.Italian => "Italian",
                VoiceCloneRequestLanguageBoost.Japanese => "Japanese",
                VoiceCloneRequestLanguageBoost.Korean => "Korean",
                VoiceCloneRequestLanguageBoost.Malay => "Malay",
                VoiceCloneRequestLanguageBoost.Norwegian => "Norwegian",
                VoiceCloneRequestLanguageBoost.Nynorsk => "Nynorsk",
                VoiceCloneRequestLanguageBoost.Persian => "Persian",
                VoiceCloneRequestLanguageBoost.Polish => "Polish",
                VoiceCloneRequestLanguageBoost.Portuguese => "Portuguese",
                VoiceCloneRequestLanguageBoost.Romanian => "Romanian",
                VoiceCloneRequestLanguageBoost.Russian => "Russian",
                VoiceCloneRequestLanguageBoost.Slovak => "Slovak",
                VoiceCloneRequestLanguageBoost.Slovenian => "Slovenian",
                VoiceCloneRequestLanguageBoost.Spanish => "Spanish",
                VoiceCloneRequestLanguageBoost.Swedish => "Swedish",
                VoiceCloneRequestLanguageBoost.Tamil => "Tamil",
                VoiceCloneRequestLanguageBoost.Thai => "Thai",
                VoiceCloneRequestLanguageBoost.Turkish => "Turkish",
                VoiceCloneRequestLanguageBoost.Ukrainian => "Ukrainian",
                VoiceCloneRequestLanguageBoost.Vietnamese => "Vietnamese",
                VoiceCloneRequestLanguageBoost.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceCloneRequestLanguageBoost? ToEnum(string value)
        {
            return value switch
            {
                "Afrikaans" => VoiceCloneRequestLanguageBoost.Afrikaans,
                "Arabic" => VoiceCloneRequestLanguageBoost.Arabic,
                "Bulgarian" => VoiceCloneRequestLanguageBoost.Bulgarian,
                "Catalan" => VoiceCloneRequestLanguageBoost.Catalan,
                "Chinese" => VoiceCloneRequestLanguageBoost.Chinese,
                "Chinese,Yue" => VoiceCloneRequestLanguageBoost.Chinese_Yue,
                "Croatian" => VoiceCloneRequestLanguageBoost.Croatian,
                "Czech" => VoiceCloneRequestLanguageBoost.Czech,
                "Danish" => VoiceCloneRequestLanguageBoost.Danish,
                "Dutch" => VoiceCloneRequestLanguageBoost.Dutch,
                "English" => VoiceCloneRequestLanguageBoost.English,
                "Filipino" => VoiceCloneRequestLanguageBoost.Filipino,
                "Finnish" => VoiceCloneRequestLanguageBoost.Finnish,
                "French" => VoiceCloneRequestLanguageBoost.French,
                "German" => VoiceCloneRequestLanguageBoost.German,
                "Greek" => VoiceCloneRequestLanguageBoost.Greek,
                "Hebrew" => VoiceCloneRequestLanguageBoost.Hebrew,
                "Hindi" => VoiceCloneRequestLanguageBoost.Hindi,
                "Hungarian" => VoiceCloneRequestLanguageBoost.Hungarian,
                "Indonesian" => VoiceCloneRequestLanguageBoost.Indonesian,
                "Italian" => VoiceCloneRequestLanguageBoost.Italian,
                "Japanese" => VoiceCloneRequestLanguageBoost.Japanese,
                "Korean" => VoiceCloneRequestLanguageBoost.Korean,
                "Malay" => VoiceCloneRequestLanguageBoost.Malay,
                "Norwegian" => VoiceCloneRequestLanguageBoost.Norwegian,
                "Nynorsk" => VoiceCloneRequestLanguageBoost.Nynorsk,
                "Persian" => VoiceCloneRequestLanguageBoost.Persian,
                "Polish" => VoiceCloneRequestLanguageBoost.Polish,
                "Portuguese" => VoiceCloneRequestLanguageBoost.Portuguese,
                "Romanian" => VoiceCloneRequestLanguageBoost.Romanian,
                "Russian" => VoiceCloneRequestLanguageBoost.Russian,
                "Slovak" => VoiceCloneRequestLanguageBoost.Slovak,
                "Slovenian" => VoiceCloneRequestLanguageBoost.Slovenian,
                "Spanish" => VoiceCloneRequestLanguageBoost.Spanish,
                "Swedish" => VoiceCloneRequestLanguageBoost.Swedish,
                "Tamil" => VoiceCloneRequestLanguageBoost.Tamil,
                "Thai" => VoiceCloneRequestLanguageBoost.Thai,
                "Turkish" => VoiceCloneRequestLanguageBoost.Turkish,
                "Ukrainian" => VoiceCloneRequestLanguageBoost.Ukrainian,
                "Vietnamese" => VoiceCloneRequestLanguageBoost.Vietnamese,
                "auto" => VoiceCloneRequestLanguageBoost.Auto,
                _ => null,
            };
        }
    }
}