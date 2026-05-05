
#nullable enable

namespace MiniMax
{
    public partial class SpeechClient
    {

        private static readonly global::MiniMax.AutoSDKServer[] s_CreateTextToSpeechServers = new global::MiniMax.AutoSDKServer[]
        {            new global::MiniMax.AutoSDKServer(
                id: "https-api-minimax-io",
                name: "MiniMax Global Production API",
                url: "https://api.minimax.io/",
                description: "MiniMax Global Production API"),
            new global::MiniMax.AutoSDKServer(
                id: "https-api-minimaxi-chat",
                name: "MiniMax China Mainland API",
                url: "https://api.minimaxi.chat/",
                description: "MiniMax China Mainland API"),
        };


        private static readonly global::MiniMax.EndPointSecurityRequirement s_CreateTextToSpeechSecurityRequirement0 =
            new global::MiniMax.EndPointSecurityRequirement
            {
                Authorizations = new global::MiniMax.EndPointAuthorizationRequirement[]
                {                    new global::MiniMax.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "HttpBearer",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::MiniMax.EndPointSecurityRequirement[] s_CreateTextToSpeechSecurityRequirements =
            new global::MiniMax.EndPointSecurityRequirement[]
            {                s_CreateTextToSpeechSecurityRequirement0,
            };
        partial void PrepareCreateTextToSpeechArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::MiniMax.TextToSpeechRequest request);
        partial void PrepareCreateTextToSpeechRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::MiniMax.TextToSpeechRequest request);
        partial void ProcessCreateTextToSpeechResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateTextToSpeechResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Synthesize speech (T2A v2).<br/>
        /// Converts text to speech using MiniMax TTS models<br/>
        /// (`speech-2.8-hd`, `speech-2.8-turbo`, `speech-2.6-hd`,<br/>
        /// `speech-2.6-turbo`, `speech-02-hd`, `speech-02-turbo`). Supports up<br/>
        /// to 10,000 characters, 40 languages, and 7 emotional tones.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MiniMax.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::MiniMax.TextToSpeechResponse> CreateTextToSpeechAsync(

            global::MiniMax.TextToSpeechRequest request,
            global::MiniMax.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await CreateTextToSpeechAsResponseAsync(

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Synthesize speech (T2A v2).<br/>
        /// Converts text to speech using MiniMax TTS models<br/>
        /// (`speech-2.8-hd`, `speech-2.8-turbo`, `speech-2.6-hd`,<br/>
        /// `speech-2.6-turbo`, `speech-02-hd`, `speech-02-turbo`). Supports up<br/>
        /// to 10,000 characters, 40 languages, and 7 emotional tones.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MiniMax.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::MiniMax.AutoSDKHttpResponse<global::MiniMax.TextToSpeechResponse>> CreateTextToSpeechAsResponseAsync(

            global::MiniMax.TextToSpeechRequest request,
            global::MiniMax.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateTextToSpeechArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::MiniMax.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateTextToSpeechSecurityRequirements,
                operationName: "CreateTextToSpeechAsync");

            using var __timeoutCancellationTokenSource = global::MiniMax.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::MiniMax.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::MiniMax.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: false);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::MiniMax.PathBuilder(
                                path: "/v1/t2a_v2",
                                baseUri: ResolveBaseUri(
                                servers: s_CreateTextToSpeechServers,
                                defaultBaseUrl: "https://api.minimax.io/"));
                            var __path = __pathBuilder.ToString();
                __path = global::MiniMax.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                } 
            }
                            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
                            var __httpRequestContent = new global::System.Net.Http.StringContent(
                                content: __httpRequestContentBody,
                                encoding: global::System.Text.Encoding.UTF8,
                                mediaType: "application/json");
                            __httpRequest.Content = __httpRequestContent;
                global::MiniMax.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareCreateTextToSpeechRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::MiniMax.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::MiniMax.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateTextToSpeech",
                                methodName: "CreateTextToSpeechAsync",
                                pathTemplate: "\"/v1/t2a_v2\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::MiniMax.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::MiniMax.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::MiniMax.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateTextToSpeech",
                                methodName: "CreateTextToSpeechAsync",
                                pathTemplate: "\"/v1/t2a_v2\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::MiniMax.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::MiniMax.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::MiniMax.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::MiniMax.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::MiniMax.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateTextToSpeech",
                                methodName: "CreateTextToSpeechAsync",
                                pathTemplate: "\"/v1/t2a_v2\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::MiniMax.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessCreateTextToSpeechResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::MiniMax.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::MiniMax.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateTextToSpeech",
                                methodName: "CreateTextToSpeechAsync",
                                pathTemplate: "\"/v1/t2a_v2\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::MiniMax.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::MiniMax.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateTextToSpeech",
                                methodName: "CreateTextToSpeechAsync",
                                pathTemplate: "\"/v1/t2a_v2\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessCreateTextToSpeechResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::MiniMax.TextToSpeechResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::MiniMax.AutoSDKHttpResponse<global::MiniMax.TextToSpeechResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::MiniMax.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw new global::MiniMax.ApiException(
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        statusCode: __response.StatusCode)
                                    {
                                        ResponseBody = __content,
                                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value),
                                    };
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = await global::MiniMax.TextToSpeechResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::MiniMax.AutoSDKHttpResponse<global::MiniMax.TextToSpeechResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::MiniMax.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
                #endif
                                        ).ConfigureAwait(false);
                                    }
                                    catch (global::System.Exception)
                                    {
                                    }

                                    throw new global::MiniMax.ApiException(
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        statusCode: __response.StatusCode)
                                    {
                                        ResponseBody = __content,
                                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value),
                                    };
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
        /// <summary>
        /// Synthesize speech (T2A v2).<br/>
        /// Converts text to speech using MiniMax TTS models<br/>
        /// (`speech-2.8-hd`, `speech-2.8-turbo`, `speech-2.6-hd`,<br/>
        /// `speech-2.6-turbo`, `speech-02-hd`, `speech-02-turbo`). Supports up<br/>
        /// to 10,000 characters, 40 languages, and 7 emotional tones.
        /// </summary>
        /// <param name="model">
        /// TTS model version: `speech-2.8-hd`, `speech-2.8-turbo`,<br/>
        /// `speech-2.6-hd`, `speech-2.6-turbo`, `speech-02-hd`,<br/>
        /// `speech-02-turbo`, `speech-01-hd`, `speech-01-turbo`.
        /// </param>
        /// <param name="text">
        /// Input text, up to 10,000 characters. Use `\n` for paragraph breaks.
        /// </param>
        /// <param name="stream">
        /// Whether to stream the output.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="streamOptions"></param>
        /// <param name="voiceSetting">
        /// Voice configuration for TTS.
        /// </param>
        /// <param name="audioSetting">
        /// Audio output configuration for TTS.
        /// </param>
        /// <param name="pronunciationDict">
        /// Custom pronunciation rules.
        /// </param>
        /// <param name="voiceModify">
        /// Voice effect/modulation settings.
        /// </param>
        /// <param name="timberWeights">
        /// Mix multiple voices by weight (up to 4 entries).
        /// </param>
        /// <param name="languageBoost">
        /// Bias pronunciation toward a specific language, or `auto` to<br/>
        /// auto-detect. Examples — `English`, `Chinese`, `Japanese`,<br/>
        /// `Korean`, `auto`.
        /// </param>
        /// <param name="outputFormat">
        /// Output format (non-streaming only).<br/>
        /// Default Value: hex
        /// </param>
        /// <param name="subtitleEnable">
        /// Whether to return subtitle files alongside the audio.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::MiniMax.TextToSpeechResponse> CreateTextToSpeechAsync(
            string model,
            string text,
            global::MiniMax.TtsVoiceSetting voiceSetting,
            bool? stream = default,
            global::MiniMax.TtsStreamOptions? streamOptions = default,
            global::MiniMax.TtsAudioSetting? audioSetting = default,
            global::MiniMax.TtsPronunciationDict? pronunciationDict = default,
            global::MiniMax.TtsVoiceModify? voiceModify = default,
            global::System.Collections.Generic.IList<global::MiniMax.TimberWeight>? timberWeights = default,
            string? languageBoost = default,
            global::MiniMax.TextToSpeechRequestOutputFormat? outputFormat = default,
            bool? subtitleEnable = default,
            global::MiniMax.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::MiniMax.TextToSpeechRequest
            {
                Model = model,
                Text = text,
                Stream = stream,
                StreamOptions = streamOptions,
                VoiceSetting = voiceSetting,
                AudioSetting = audioSetting,
                PronunciationDict = pronunciationDict,
                VoiceModify = voiceModify,
                TimberWeights = timberWeights,
                LanguageBoost = languageBoost,
                OutputFormat = outputFormat,
                SubtitleEnable = subtitleEnable,
            };

            return await CreateTextToSpeechAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}