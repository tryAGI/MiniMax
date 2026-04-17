
#nullable enable

namespace MiniMax
{
    public partial class SpeechClient
    {

        private static readonly global::MiniMax.AutoSDKServer[] s_CreateVoiceCloneServers = new global::MiniMax.AutoSDKServer[]
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


        private static readonly global::MiniMax.EndPointSecurityRequirement s_CreateVoiceCloneSecurityRequirement0 =
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
        private static readonly global::MiniMax.EndPointSecurityRequirement[] s_CreateVoiceCloneSecurityRequirements =
            new global::MiniMax.EndPointSecurityRequirement[]
            {                s_CreateVoiceCloneSecurityRequirement0,
            };
        partial void PrepareCreateVoiceCloneArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::MiniMax.VoiceCloneRequest request);
        partial void PrepareCreateVoiceCloneRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::MiniMax.VoiceCloneRequest request);
        partial void ProcessCreateVoiceCloneResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateVoiceCloneResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create a voice clone.<br/>
        /// Creates a custom voice clone from a previously uploaded reference<br/>
        /// audio file. First upload an MP3/M4A/WAV file (10s-5min, clear<br/>
        /// speech) via `POST /v1/files/upload` with `purpose=voice_clone`, then<br/>
        /// pass the returned `file_id` here.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MiniMax.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::MiniMax.VoiceCloneResponse> CreateVoiceCloneAsync(

            global::MiniMax.VoiceCloneRequest request,
            global::MiniMax.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateVoiceCloneArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::MiniMax.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateVoiceCloneSecurityRequirements,
                operationName: "CreateVoiceCloneAsync");

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
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {
                            var __pathBuilder = new global::MiniMax.PathBuilder(
                                path: "/v1/voice_clone",
                                baseUri: ResolveBaseUri(
                                servers: s_CreateVoiceCloneServers,
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
                PrepareCreateVoiceCloneRequest(
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
                                operationId: "CreateVoiceClone",
                                methodName: "CreateVoiceCloneAsync",
                                pathTemplate: "\"/v1/voice_clone\"",
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
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::MiniMax.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::MiniMax.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateVoiceClone",
                                methodName: "CreateVoiceCloneAsync",
                                pathTemplate: "\"/v1/voice_clone\"",
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
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::MiniMax.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::MiniMax.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        await global::MiniMax.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::MiniMax.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateVoiceClone",
                                methodName: "CreateVoiceCloneAsync",
                                pathTemplate: "\"/v1/voice_clone\"",
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
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::MiniMax.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
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
                ProcessCreateVoiceCloneResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::MiniMax.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::MiniMax.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateVoiceClone",
                                methodName: "CreateVoiceCloneAsync",
                                pathTemplate: "\"/v1/voice_clone\"",
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
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::MiniMax.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::MiniMax.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateVoiceClone",
                                methodName: "CreateVoiceCloneAsync",
                                pathTemplate: "\"/v1/voice_clone\"",
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
                                ProcessCreateVoiceCloneResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    return
                                        global::MiniMax.VoiceCloneResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
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

                                    return
                                        await global::MiniMax.VoiceCloneResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
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
        /// Create a voice clone.<br/>
        /// Creates a custom voice clone from a previously uploaded reference<br/>
        /// audio file. First upload an MP3/M4A/WAV file (10s-5min, clear<br/>
        /// speech) via `POST /v1/files/upload` with `purpose=voice_clone`, then<br/>
        /// pass the returned `file_id` here.
        /// </summary>
        /// <param name="fileId">
        /// File ID returned from `POST /v1/files/upload` with `purpose=voice_clone`.
        /// </param>
        /// <param name="voiceId">
        /// Custom voice ID to assign to the clone (8–256 characters,<br/>
        /// alphanumeric, starts with a letter).
        /// </param>
        /// <param name="needNoiseReduction">
        /// Whether to apply noise reduction to the reference audio.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="needVolumeNormalization">
        /// Whether to normalize the volume of the reference audio.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="text">
        /// Optional sample text to synthesize with the new voice to confirm cloning.
        /// </param>
        /// <param name="model">
        /// TTS model to use for the sample synthesis (e.g., `speech-2.6-hd`).
        /// </param>
        /// <param name="accuracy">
        /// Cloning accuracy threshold, 0.0–1.0.
        /// </param>
        /// <param name="clonePrompt">
        /// Reference prompt-audio pair used to refine the cloned voice.
        /// </param>
        /// <param name="aigcWatermark">
        /// Whether to embed an AIGC watermark on the generated sample audio.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::MiniMax.VoiceCloneResponse> CreateVoiceCloneAsync(
            string fileId,
            string voiceId,
            bool? needNoiseReduction = default,
            bool? needVolumeNormalization = default,
            string? text = default,
            string? model = default,
            float? accuracy = default,
            global::MiniMax.VoiceClonePrompt? clonePrompt = default,
            bool? aigcWatermark = default,
            global::MiniMax.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::MiniMax.VoiceCloneRequest
            {
                FileId = fileId,
                VoiceId = voiceId,
                NeedNoiseReduction = needNoiseReduction,
                NeedVolumeNormalization = needVolumeNormalization,
                Text = text,
                Model = model,
                Accuracy = accuracy,
                ClonePrompt = clonePrompt,
                AigcWatermark = aigcWatermark,
            };

            return await CreateVoiceCloneAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}