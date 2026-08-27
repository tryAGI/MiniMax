
#nullable enable

namespace MiniMax
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MusicGenerationRequest
    {
        /// <summary>
        /// Music generation model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Music prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Lyrics with optional section markers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lyrics")]
        public string? Lyrics { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// Default Value: hex
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MiniMax.JsonConverters.MusicGenerationRequestOutputFormatJsonConverter))]
        public global::MiniMax.MusicGenerationRequestOutputFormat? OutputFormat { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_setting")]
        public global::MiniMax.MusicAudioSetting? AudioSetting { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aigc_watermark")]
        public bool? AigcWatermark { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lyrics_optimizer")]
        public bool? LyricsOptimizer { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_instrumental")]
        public bool? IsInstrumental { get; set; }

        /// <summary>
        /// Reference audio URL for cover generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_url")]
        public string? AudioUrl { get; set; }

        /// <summary>
        /// Reference audio as base64 for cover generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_base64")]
        public string? AudioBase64 { get; set; }

        /// <summary>
        /// Preprocessed cover feature ID for two-step cover generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cover_feature_id")]
        public string? CoverFeatureId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MusicGenerationRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// Music generation model.
        /// </param>
        /// <param name="prompt">
        /// Music prompt.
        /// </param>
        /// <param name="lyrics">
        /// Lyrics with optional section markers.
        /// </param>
        /// <param name="stream">
        /// Default Value: false
        /// </param>
        /// <param name="outputFormat">
        /// Default Value: hex
        /// </param>
        /// <param name="audioSetting"></param>
        /// <param name="aigcWatermark"></param>
        /// <param name="lyricsOptimizer">
        /// Default Value: false
        /// </param>
        /// <param name="isInstrumental">
        /// Default Value: false
        /// </param>
        /// <param name="audioUrl">
        /// Reference audio URL for cover generation.
        /// </param>
        /// <param name="audioBase64">
        /// Reference audio as base64 for cover generation.
        /// </param>
        /// <param name="coverFeatureId">
        /// Preprocessed cover feature ID for two-step cover generation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MusicGenerationRequest(
            string model,
            string? prompt,
            string? lyrics,
            bool? stream,
            global::MiniMax.MusicGenerationRequestOutputFormat? outputFormat,
            global::MiniMax.MusicAudioSetting? audioSetting,
            bool? aigcWatermark,
            bool? lyricsOptimizer,
            bool? isInstrumental,
            string? audioUrl,
            string? audioBase64,
            string? coverFeatureId)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Prompt = prompt;
            this.Lyrics = lyrics;
            this.Stream = stream;
            this.OutputFormat = outputFormat;
            this.AudioSetting = audioSetting;
            this.AigcWatermark = aigcWatermark;
            this.LyricsOptimizer = lyricsOptimizer;
            this.IsInstrumental = isInstrumental;
            this.AudioUrl = audioUrl;
            this.AudioBase64 = audioBase64;
            this.CoverFeatureId = coverFeatureId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MusicGenerationRequest" /> class.
        /// </summary>
        public MusicGenerationRequest()
        {
        }

    }
}