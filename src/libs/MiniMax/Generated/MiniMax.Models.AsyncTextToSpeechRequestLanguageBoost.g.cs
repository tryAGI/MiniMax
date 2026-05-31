
#nullable enable

namespace MiniMax
{
    /// <summary>
    /// 
    /// </summary>
    public enum AsyncTextToSpeechRequestLanguageBoost
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
    public static class AsyncTextToSpeechRequestLanguageBoostExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AsyncTextToSpeechRequestLanguageBoost value)
        {
            return value switch
            {
                AsyncTextToSpeechRequestLanguageBoost.Afrikaans => "Afrikaans",
                AsyncTextToSpeechRequestLanguageBoost.Arabic => "Arabic",
                AsyncTextToSpeechRequestLanguageBoost.Bulgarian => "Bulgarian",
                AsyncTextToSpeechRequestLanguageBoost.Catalan => "Catalan",
                AsyncTextToSpeechRequestLanguageBoost.Chinese => "Chinese",
                AsyncTextToSpeechRequestLanguageBoost.Chinese_Yue => "Chinese,Yue",
                AsyncTextToSpeechRequestLanguageBoost.Croatian => "Croatian",
                AsyncTextToSpeechRequestLanguageBoost.Czech => "Czech",
                AsyncTextToSpeechRequestLanguageBoost.Danish => "Danish",
                AsyncTextToSpeechRequestLanguageBoost.Dutch => "Dutch",
                AsyncTextToSpeechRequestLanguageBoost.English => "English",
                AsyncTextToSpeechRequestLanguageBoost.Filipino => "Filipino",
                AsyncTextToSpeechRequestLanguageBoost.Finnish => "Finnish",
                AsyncTextToSpeechRequestLanguageBoost.French => "French",
                AsyncTextToSpeechRequestLanguageBoost.German => "German",
                AsyncTextToSpeechRequestLanguageBoost.Greek => "Greek",
                AsyncTextToSpeechRequestLanguageBoost.Hebrew => "Hebrew",
                AsyncTextToSpeechRequestLanguageBoost.Hindi => "Hindi",
                AsyncTextToSpeechRequestLanguageBoost.Hungarian => "Hungarian",
                AsyncTextToSpeechRequestLanguageBoost.Indonesian => "Indonesian",
                AsyncTextToSpeechRequestLanguageBoost.Italian => "Italian",
                AsyncTextToSpeechRequestLanguageBoost.Japanese => "Japanese",
                AsyncTextToSpeechRequestLanguageBoost.Korean => "Korean",
                AsyncTextToSpeechRequestLanguageBoost.Malay => "Malay",
                AsyncTextToSpeechRequestLanguageBoost.Norwegian => "Norwegian",
                AsyncTextToSpeechRequestLanguageBoost.Nynorsk => "Nynorsk",
                AsyncTextToSpeechRequestLanguageBoost.Persian => "Persian",
                AsyncTextToSpeechRequestLanguageBoost.Polish => "Polish",
                AsyncTextToSpeechRequestLanguageBoost.Portuguese => "Portuguese",
                AsyncTextToSpeechRequestLanguageBoost.Romanian => "Romanian",
                AsyncTextToSpeechRequestLanguageBoost.Russian => "Russian",
                AsyncTextToSpeechRequestLanguageBoost.Slovak => "Slovak",
                AsyncTextToSpeechRequestLanguageBoost.Slovenian => "Slovenian",
                AsyncTextToSpeechRequestLanguageBoost.Spanish => "Spanish",
                AsyncTextToSpeechRequestLanguageBoost.Swedish => "Swedish",
                AsyncTextToSpeechRequestLanguageBoost.Tamil => "Tamil",
                AsyncTextToSpeechRequestLanguageBoost.Thai => "Thai",
                AsyncTextToSpeechRequestLanguageBoost.Turkish => "Turkish",
                AsyncTextToSpeechRequestLanguageBoost.Ukrainian => "Ukrainian",
                AsyncTextToSpeechRequestLanguageBoost.Vietnamese => "Vietnamese",
                AsyncTextToSpeechRequestLanguageBoost.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AsyncTextToSpeechRequestLanguageBoost? ToEnum(string value)
        {
            return value switch
            {
                "Afrikaans" => AsyncTextToSpeechRequestLanguageBoost.Afrikaans,
                "Arabic" => AsyncTextToSpeechRequestLanguageBoost.Arabic,
                "Bulgarian" => AsyncTextToSpeechRequestLanguageBoost.Bulgarian,
                "Catalan" => AsyncTextToSpeechRequestLanguageBoost.Catalan,
                "Chinese" => AsyncTextToSpeechRequestLanguageBoost.Chinese,
                "Chinese,Yue" => AsyncTextToSpeechRequestLanguageBoost.Chinese_Yue,
                "Croatian" => AsyncTextToSpeechRequestLanguageBoost.Croatian,
                "Czech" => AsyncTextToSpeechRequestLanguageBoost.Czech,
                "Danish" => AsyncTextToSpeechRequestLanguageBoost.Danish,
                "Dutch" => AsyncTextToSpeechRequestLanguageBoost.Dutch,
                "English" => AsyncTextToSpeechRequestLanguageBoost.English,
                "Filipino" => AsyncTextToSpeechRequestLanguageBoost.Filipino,
                "Finnish" => AsyncTextToSpeechRequestLanguageBoost.Finnish,
                "French" => AsyncTextToSpeechRequestLanguageBoost.French,
                "German" => AsyncTextToSpeechRequestLanguageBoost.German,
                "Greek" => AsyncTextToSpeechRequestLanguageBoost.Greek,
                "Hebrew" => AsyncTextToSpeechRequestLanguageBoost.Hebrew,
                "Hindi" => AsyncTextToSpeechRequestLanguageBoost.Hindi,
                "Hungarian" => AsyncTextToSpeechRequestLanguageBoost.Hungarian,
                "Indonesian" => AsyncTextToSpeechRequestLanguageBoost.Indonesian,
                "Italian" => AsyncTextToSpeechRequestLanguageBoost.Italian,
                "Japanese" => AsyncTextToSpeechRequestLanguageBoost.Japanese,
                "Korean" => AsyncTextToSpeechRequestLanguageBoost.Korean,
                "Malay" => AsyncTextToSpeechRequestLanguageBoost.Malay,
                "Norwegian" => AsyncTextToSpeechRequestLanguageBoost.Norwegian,
                "Nynorsk" => AsyncTextToSpeechRequestLanguageBoost.Nynorsk,
                "Persian" => AsyncTextToSpeechRequestLanguageBoost.Persian,
                "Polish" => AsyncTextToSpeechRequestLanguageBoost.Polish,
                "Portuguese" => AsyncTextToSpeechRequestLanguageBoost.Portuguese,
                "Romanian" => AsyncTextToSpeechRequestLanguageBoost.Romanian,
                "Russian" => AsyncTextToSpeechRequestLanguageBoost.Russian,
                "Slovak" => AsyncTextToSpeechRequestLanguageBoost.Slovak,
                "Slovenian" => AsyncTextToSpeechRequestLanguageBoost.Slovenian,
                "Spanish" => AsyncTextToSpeechRequestLanguageBoost.Spanish,
                "Swedish" => AsyncTextToSpeechRequestLanguageBoost.Swedish,
                "Tamil" => AsyncTextToSpeechRequestLanguageBoost.Tamil,
                "Thai" => AsyncTextToSpeechRequestLanguageBoost.Thai,
                "Turkish" => AsyncTextToSpeechRequestLanguageBoost.Turkish,
                "Ukrainian" => AsyncTextToSpeechRequestLanguageBoost.Ukrainian,
                "Vietnamese" => AsyncTextToSpeechRequestLanguageBoost.Vietnamese,
                "auto" => AsyncTextToSpeechRequestLanguageBoost.Auto,
                _ => null,
            };
        }
    }
}