
#nullable enable

namespace MiniMax
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MusicGenerationRequest
    {
        /// <summary>
        /// Music model. Supported values:<br/>
        /// `music-2.6`, `music-cover`, `music-2.6-free`, `music-cover-free`,<br/>
        /// `music-2.0`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Music description (style, mood, scenario) — 1 to 2000 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Song lyrics with `\n` line breaks. Supports structure tags such as<br/>
        /// `[Verse]`, `[Chorus]`, `[Bridge]`. 1 to 3500 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lyrics")]
        public string? Lyrics { get; set; }

        /// <summary>
        /// Whether to stream the output (server-sent events).<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// Output format — `hex` returns hex-encoded bytes inline, `url` returns a downloadable link.<br/>
        /// Default Value: hex
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MiniMax.JsonConverters.MusicGenerationRequestOutputFormatJsonConverter))]
        public global::MiniMax.MusicGenerationRequestOutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// Audio output configuration for music generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_setting")]
        public global::MiniMax.MusicAudioSetting? AudioSetting { get; set; }

        /// <summary>
        /// Whether to auto-generate lyrics from the prompt.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lyrics_optimizer")]
        public bool? LyricsOptimizer { get; set; }

        /// <summary>
        /// Whether to generate instrumental music (no vocals).<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_instrumental")]
        public bool? IsInstrumental { get; set; }

        /// <summary>
        /// Reference audio URL for `music-cover` models.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_url")]
        public string? AudioUrl { get; set; }

        /// <summary>
        /// Base64-encoded reference audio for `music-cover` models.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_base64")]
        public string? AudioBase64 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MusicGenerationRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// Music model. Supported values:<br/>
        /// `music-2.6`, `music-cover`, `music-2.6-free`, `music-cover-free`,<br/>
        /// `music-2.0`.
        /// </param>
        /// <param name="prompt">
        /// Music description (style, mood, scenario) — 1 to 2000 characters.
        /// </param>
        /// <param name="lyrics">
        /// Song lyrics with `\n` line breaks. Supports structure tags such as<br/>
        /// `[Verse]`, `[Chorus]`, `[Bridge]`. 1 to 3500 characters.
        /// </param>
        /// <param name="stream">
        /// Whether to stream the output (server-sent events).<br/>
        /// Default Value: false
        /// </param>
        /// <param name="outputFormat">
        /// Output format — `hex` returns hex-encoded bytes inline, `url` returns a downloadable link.<br/>
        /// Default Value: hex
        /// </param>
        /// <param name="audioSetting">
        /// Audio output configuration for music generation.
        /// </param>
        /// <param name="lyricsOptimizer">
        /// Whether to auto-generate lyrics from the prompt.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="isInstrumental">
        /// Whether to generate instrumental music (no vocals).<br/>
        /// Default Value: false
        /// </param>
        /// <param name="audioUrl">
        /// Reference audio URL for `music-cover` models.
        /// </param>
        /// <param name="audioBase64">
        /// Base64-encoded reference audio for `music-cover` models.
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
            bool? lyricsOptimizer,
            bool? isInstrumental,
            string? audioUrl,
            string? audioBase64)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Prompt = prompt;
            this.Lyrics = lyrics;
            this.Stream = stream;
            this.OutputFormat = outputFormat;
            this.AudioSetting = audioSetting;
            this.LyricsOptimizer = lyricsOptimizer;
            this.IsInstrumental = isInstrumental;
            this.AudioUrl = audioUrl;
            this.AudioBase64 = audioBase64;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MusicGenerationRequest" /> class.
        /// </summary>
        public MusicGenerationRequest()
        {
        }
    }
}