
#nullable enable

namespace MiniMax
{
    public partial class VideoClient
    {

        private static readonly global::MiniMax.AutoSDKServer[] s_CreateVideoGenerationTaskServers = new global::MiniMax.AutoSDKServer[]
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


        private static readonly global::MiniMax.EndPointSecurityRequirement s_CreateVideoGenerationTaskSecurityRequirement0 =
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
        private static readonly global::MiniMax.EndPointSecurityRequirement[] s_CreateVideoGenerationTaskSecurityRequirements =
            new global::MiniMax.EndPointSecurityRequirement[]
            {                s_CreateVideoGenerationTaskSecurityRequirement0,
            };
        partial void PrepareCreateVideoGenerationTaskArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::MiniMax.VideoGenerationRequest request);
        partial void PrepareCreateVideoGenerationTaskRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::MiniMax.VideoGenerationRequest request);
        partial void ProcessCreateVideoGenerationTaskResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateVideoGenerationTaskResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create a video generation task.<br/>
        /// Creates an asynchronous video generation task using Hailuo video<br/>
        /// models. Returns a `task_id` that must be polled via<br/>
        /// `GET /v1/query/video_generation` until the task succeeds or fails.<br/>
        /// Once complete, the resulting file is retrieved via<br/>
        /// `GET /v1/files/retrieve`.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MiniMax.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::MiniMax.VideoGenerationResponse> CreateVideoGenerationTaskAsync(

            global::MiniMax.VideoGenerationRequest request,
            global::MiniMax.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await CreateVideoGenerationTaskAsResponseAsync(

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Create a video generation task.<br/>
        /// Creates an asynchronous video generation task using Hailuo video<br/>
        /// models. Returns a `task_id` that must be polled via<br/>
        /// `GET /v1/query/video_generation` until the task succeeds or fails.<br/>
        /// Once complete, the resulting file is retrieved via<br/>
        /// `GET /v1/files/retrieve`.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MiniMax.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::MiniMax.AutoSDKHttpResponse<global::MiniMax.VideoGenerationResponse>> CreateVideoGenerationTaskAsResponseAsync(

            global::MiniMax.VideoGenerationRequest request,
            global::MiniMax.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateVideoGenerationTaskArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::MiniMax.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateVideoGenerationTaskSecurityRequirements,
                operationName: "CreateVideoGenerationTaskAsync");

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
                                path: "/v1/video_generation",
                                baseUri: ResolveBaseUri(
                                servers: s_CreateVideoGenerationTaskServers,
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
                PrepareCreateVideoGenerationTaskRequest(
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
                                operationId: "CreateVideoGenerationTask",
                                methodName: "CreateVideoGenerationTaskAsync",
                                pathTemplate: "\"/v1/video_generation\"",
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
                                operationId: "CreateVideoGenerationTask",
                                methodName: "CreateVideoGenerationTaskAsync",
                                pathTemplate: "\"/v1/video_generation\"",
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
                                operationId: "CreateVideoGenerationTask",
                                methodName: "CreateVideoGenerationTaskAsync",
                                pathTemplate: "\"/v1/video_generation\"",
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
                ProcessCreateVideoGenerationTaskResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::MiniMax.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::MiniMax.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateVideoGenerationTask",
                                methodName: "CreateVideoGenerationTaskAsync",
                                pathTemplate: "\"/v1/video_generation\"",
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
                                operationId: "CreateVideoGenerationTask",
                                methodName: "CreateVideoGenerationTaskAsync",
                                pathTemplate: "\"/v1/video_generation\"",
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
                                ProcessCreateVideoGenerationTaskResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::MiniMax.VideoGenerationResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::MiniMax.AutoSDKHttpResponse<global::MiniMax.VideoGenerationResponse>(
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

                                    var __value = await global::MiniMax.VideoGenerationResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::MiniMax.AutoSDKHttpResponse<global::MiniMax.VideoGenerationResponse>(
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
        /// Create a video generation task.<br/>
        /// Creates an asynchronous video generation task using Hailuo video<br/>
        /// models. Returns a `task_id` that must be polled via<br/>
        /// `GET /v1/query/video_generation` until the task succeeds or fails.<br/>
        /// Once complete, the resulting file is retrieved via<br/>
        /// `GET /v1/files/retrieve`.
        /// </summary>
        /// <param name="model">
        /// Model identifier. Popular choices:<br/>
        /// `MiniMax-Hailuo-2.3`, `MiniMax-Hailuo-2.3-Fast`,<br/>
        /// `MiniMax-Hailuo-02`, `T2V-01-Director`, `I2V-01-Director`,<br/>
        /// `S2V-01`.
        /// </param>
        /// <param name="prompt">
        /// Natural-language description of the desired video motion and content.
        /// </param>
        /// <param name="promptOptimizer">
        /// Whether to auto-optimize the prompt for better results.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="firstFrameImage">
        /// Starting frame image URL or data URI (image-to-video and start-end modes).
        /// </param>
        /// <param name="lastFrameImage">
        /// Ending frame image URL or data URI (start-end mode only).
        /// </param>
        /// <param name="subjectReference">
        /// Subject references for subject-reference generation (S2V).
        /// </param>
        /// <param name="duration">
        /// Video length in seconds (typically 6 or 10 depending on model).
        /// </param>
        /// <param name="resolution">
        /// Output resolution.
        /// </param>
        /// <param name="callbackUrl">
        /// Optional webhook URL invoked when the task completes.
        /// </param>
        /// <param name="aigcWatermark">
        /// Whether to embed an AIGC watermark in the output.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::MiniMax.VideoGenerationResponse> CreateVideoGenerationTaskAsync(
            string model,
            string? prompt = default,
            bool? promptOptimizer = default,
            string? firstFrameImage = default,
            string? lastFrameImage = default,
            global::System.Collections.Generic.IList<global::MiniMax.VideoSubjectReference>? subjectReference = default,
            int? duration = default,
            global::MiniMax.VideoGenerationRequestResolution? resolution = default,
            string? callbackUrl = default,
            bool? aigcWatermark = default,
            global::MiniMax.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::MiniMax.VideoGenerationRequest
            {
                Model = model,
                Prompt = prompt,
                PromptOptimizer = promptOptimizer,
                FirstFrameImage = firstFrameImage,
                LastFrameImage = lastFrameImage,
                SubjectReference = subjectReference,
                Duration = duration,
                Resolution = resolution,
                CallbackUrl = callbackUrl,
                AigcWatermark = aigcWatermark,
            };

            return await CreateVideoGenerationTaskAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}