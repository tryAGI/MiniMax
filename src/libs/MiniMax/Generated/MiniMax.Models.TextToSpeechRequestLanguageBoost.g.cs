
#nullable enable

namespace MiniMax
{
    /// <summary>
    /// 
    /// </summary>
    public enum TextToSpeechRequestLanguageBoost
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
    public static class TextToSpeechRequestLanguageBoostExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextToSpeechRequestLanguageBoost value)
        {
            return value switch
            {
                TextToSpeechRequestLanguageBoost.Afrikaans => "Afrikaans",
                TextToSpeechRequestLanguageBoost.Arabic => "Arabic",
                TextToSpeechRequestLanguageBoost.Bulgarian => "Bulgarian",
                TextToSpeechRequestLanguageBoost.Catalan => "Catalan",
                TextToSpeechRequestLanguageBoost.Chinese => "Chinese",
                TextToSpeechRequestLanguageBoost.Chinese_Yue => "Chinese,Yue",
                TextToSpeechRequestLanguageBoost.Croatian => "Croatian",
                TextToSpeechRequestLanguageBoost.Czech => "Czech",
                TextToSpeechRequestLanguageBoost.Danish => "Danish",
                TextToSpeechRequestLanguageBoost.Dutch => "Dutch",
                TextToSpeechRequestLanguageBoost.English => "English",
                TextToSpeechRequestLanguageBoost.Filipino => "Filipino",
                TextToSpeechRequestLanguageBoost.Finnish => "Finnish",
                TextToSpeechRequestLanguageBoost.French => "French",
                TextToSpeechRequestLanguageBoost.German => "German",
                TextToSpeechRequestLanguageBoost.Greek => "Greek",
                TextToSpeechRequestLanguageBoost.Hebrew => "Hebrew",
                TextToSpeechRequestLanguageBoost.Hindi => "Hindi",
                TextToSpeechRequestLanguageBoost.Hungarian => "Hungarian",
                TextToSpeechRequestLanguageBoost.Indonesian => "Indonesian",
                TextToSpeechRequestLanguageBoost.Italian => "Italian",
                TextToSpeechRequestLanguageBoost.Japanese => "Japanese",
                TextToSpeechRequestLanguageBoost.Korean => "Korean",
                TextToSpeechRequestLanguageBoost.Malay => "Malay",
                TextToSpeechRequestLanguageBoost.Norwegian => "Norwegian",
                TextToSpeechRequestLanguageBoost.Nynorsk => "Nynorsk",
                TextToSpeechRequestLanguageBoost.Persian => "Persian",
                TextToSpeechRequestLanguageBoost.Polish => "Polish",
                TextToSpeechRequestLanguageBoost.Portuguese => "Portuguese",
                TextToSpeechRequestLanguageBoost.Romanian => "Romanian",
                TextToSpeechRequestLanguageBoost.Russian => "Russian",
                TextToSpeechRequestLanguageBoost.Slovak => "Slovak",
                TextToSpeechRequestLanguageBoost.Slovenian => "Slovenian",
                TextToSpeechRequestLanguageBoost.Spanish => "Spanish",
                TextToSpeechRequestLanguageBoost.Swedish => "Swedish",
                TextToSpeechRequestLanguageBoost.Tamil => "Tamil",
                TextToSpeechRequestLanguageBoost.Thai => "Thai",
                TextToSpeechRequestLanguageBoost.Turkish => "Turkish",
                TextToSpeechRequestLanguageBoost.Ukrainian => "Ukrainian",
                TextToSpeechRequestLanguageBoost.Vietnamese => "Vietnamese",
                TextToSpeechRequestLanguageBoost.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextToSpeechRequestLanguageBoost? ToEnum(string value)
        {
            return value switch
            {
                "Afrikaans" => TextToSpeechRequestLanguageBoost.Afrikaans,
                "Arabic" => TextToSpeechRequestLanguageBoost.Arabic,
                "Bulgarian" => TextToSpeechRequestLanguageBoost.Bulgarian,
                "Catalan" => TextToSpeechRequestLanguageBoost.Catalan,
                "Chinese" => TextToSpeechRequestLanguageBoost.Chinese,
                "Chinese,Yue" => TextToSpeechRequestLanguageBoost.Chinese_Yue,
                "Croatian" => TextToSpeechRequestLanguageBoost.Croatian,
                "Czech" => TextToSpeechRequestLanguageBoost.Czech,
                "Danish" => TextToSpeechRequestLanguageBoost.Danish,
                "Dutch" => TextToSpeechRequestLanguageBoost.Dutch,
                "English" => TextToSpeechRequestLanguageBoost.English,
                "Filipino" => TextToSpeechRequestLanguageBoost.Filipino,
                "Finnish" => TextToSpeechRequestLanguageBoost.Finnish,
                "French" => TextToSpeechRequestLanguageBoost.French,
                "German" => TextToSpeechRequestLanguageBoost.German,
                "Greek" => TextToSpeechRequestLanguageBoost.Greek,
                "Hebrew" => TextToSpeechRequestLanguageBoost.Hebrew,
                "Hindi" => TextToSpeechRequestLanguageBoost.Hindi,
                "Hungarian" => TextToSpeechRequestLanguageBoost.Hungarian,
                "Indonesian" => TextToSpeechRequestLanguageBoost.Indonesian,
                "Italian" => TextToSpeechRequestLanguageBoost.Italian,
                "Japanese" => TextToSpeechRequestLanguageBoost.Japanese,
                "Korean" => TextToSpeechRequestLanguageBoost.Korean,
                "Malay" => TextToSpeechRequestLanguageBoost.Malay,
                "Norwegian" => TextToSpeechRequestLanguageBoost.Norwegian,
                "Nynorsk" => TextToSpeechRequestLanguageBoost.Nynorsk,
                "Persian" => TextToSpeechRequestLanguageBoost.Persian,
                "Polish" => TextToSpeechRequestLanguageBoost.Polish,
                "Portuguese" => TextToSpeechRequestLanguageBoost.Portuguese,
                "Romanian" => TextToSpeechRequestLanguageBoost.Romanian,
                "Russian" => TextToSpeechRequestLanguageBoost.Russian,
                "Slovak" => TextToSpeechRequestLanguageBoost.Slovak,
                "Slovenian" => TextToSpeechRequestLanguageBoost.Slovenian,
                "Spanish" => TextToSpeechRequestLanguageBoost.Spanish,
                "Swedish" => TextToSpeechRequestLanguageBoost.Swedish,
                "Tamil" => TextToSpeechRequestLanguageBoost.Tamil,
                "Thai" => TextToSpeechRequestLanguageBoost.Thai,
                "Turkish" => TextToSpeechRequestLanguageBoost.Turkish,
                "Ukrainian" => TextToSpeechRequestLanguageBoost.Ukrainian,
                "Vietnamese" => TextToSpeechRequestLanguageBoost.Vietnamese,
                "auto" => TextToSpeechRequestLanguageBoost.Auto,
                _ => null,
            };
        }
    }
}