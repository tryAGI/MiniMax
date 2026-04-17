
#nullable enable

namespace MiniMax
{
    /// <summary>
    /// MiniMax Platform API for AI-powered video generation (Hailuo),<br/>
    /// music generation, text-to-speech (T2A v2), voice cloning, and file<br/>
    /// management.<br/>
    /// **Scope:** This SDK covers video, music, TTS, voice cloning, and file<br/>
    /// upload/retrieval endpoints. LLM chat completions (OpenAI-compatible<br/>
    /// `/v1/text/chatcompletion_v2`) are **excluded** — use<br/>
    /// `tryAGI.OpenAI.CustomProviders.Minimax(...)` instead.<br/>
    /// **Authentication:** `Authorization: Bearer &lt;API_KEY&gt;` with an API key from<br/>
    /// the [MiniMax Platform](https://platform.minimax.io/user-center/basic-information/interface-key).<br/>
    /// **Base URL:** `https://api.minimax.io` (global) or `https://api.minimaxi.chat`<br/>
    /// for China mainland. Default in this SDK is the global endpoint.<br/>
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
        /// File upload/retrieval for assets used by video, music, and voice-clone endpoints.
        /// </summary>
        public FilesClient Files { get; }

        /// <summary>
        /// Music generation (text-to-music, music cover) — returns hex-encoded or URL audio.
        /// </summary>
        public MusicClient Music { get; }

        /// <summary>
        /// Text-to-speech synthesis (T2A v2) and voice cloning.
        /// </summary>
        public SpeechClient Speech { get; }

        /// <summary>
        /// Video generation via Hailuo models (text-to-video, image-to-video, subject reference) with async task polling.
        /// </summary>
        public VideoClient Video { get; }

    }
}