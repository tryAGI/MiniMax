
#nullable enable

namespace MiniMax
{
    /// <summary>
    /// MiniMax Platform API for image generation, Hailuo video generation, music generation,<br/>
    /// text-to-speech, voice workflows, video templates, and file management.<br/>
    /// **Scope:** This SDK covers the currently documented non-chat REST endpoints for<br/>
    /// images, video, music, speech, voice management, and files. OpenAI-compatible<br/>
    /// `/v1/text/chatcompletion_v2`, Anthropic-compatible chat, embeddings, and WebSocket<br/>
    /// TTS are excluded from this SDK surface.<br/>
    /// **Authentication:** `Authorization: Bearer &lt;API_KEY&gt;` from the<br/>
    /// [MiniMax Platform](https://platform.minimax.io/user-center/basic-information/interface-key).<br/>
    /// **Base URLs:** `https://api.minimax.io` for international accounts and<br/>
    /// `https://api.minimaxi.com` for accounts registered in mainland China.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IMiniMaxClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }


        /// <summary>
        /// The server options available for this client.
        /// </summary>
        public global::System.Collections.Generic.IReadOnlyList<global::MiniMax.AutoSDKServer> AvailableServers { get; }

        /// <summary>
        /// The currently selected server for this client, if any.
        /// </summary>
        public global::MiniMax.AutoSDKServer? SelectedServer { get; set; }

        /// <summary>
        /// Selects one of the generated server options by id.
        /// </summary>
        public bool TrySelectServer(string serverId);

        /// <summary>
        /// Clears the currently selected server.
        /// </summary>
        public void ClearSelectedServer();

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::MiniMax.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }
        /// <summary>
        /// Client-wide request defaults such as headers, query parameters, retries, and timeout.
        /// </summary>
        public global::MiniMax.AutoSDKClientOptions Options { get; }


        /// <summary>
        ///
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        /// Upload, retrieve, download, list, and delete files used by MiniMax workflows.
        /// </summary>
        public FilesClient Files { get; }

        /// <summary>
        /// Image generation from text prompts or reference images.
        /// </summary>
        public ImageClient Image { get; }

        /// <summary>
        /// Music generation, music-cover preprocessing, and lyrics generation.
        /// </summary>
        public MusicClient Music { get; }

        /// <summary>
        /// Text-to-speech, async TTS, voice cloning, voice design, and voice management.
        /// </summary>
        public SpeechClient Speech { get; }

        /// <summary>
        /// Hailuo video generation, task polling, and video template workflows.
        /// </summary>
        public VideoClient Video { get; }

    }
}