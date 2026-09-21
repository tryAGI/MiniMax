
#nullable enable

namespace MiniMax
{
    public partial class SpeechClient
    {

        private static readonly global::MiniMax.AutoSDKServer[] s_CreateTextToSpeechAsStreamServers = new global::MiniMax.AutoSDKServer[]
        {            new global::MiniMax.AutoSDKServer(
                id: "https-api-minimax-io",
                name: "MiniMax International Production API",
                url: "https://api.minimax.io/",
                description: "MiniMax International Production API"),
            new global::MiniMax.AutoSDKServer(
                id: "https-api-minimaxi-com",
                name: "MiniMax Mainland China Production API",
                url: "https://api.minimaxi.com/",
                description: "MiniMax Mainland China Production API"),
        };


        private static readonly global::MiniMax.EndPointSecurityRequirement s_CreateTextToSpeechAsStreamSecurityRequirement0 =
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
        private static readonly global::MiniMax.EndPointSecurityRequirement[] s_CreateTextToSpeechAsStreamSecurityRequirements =
            new global::MiniMax.EndPointSecurityRequirement[]
            {                s_CreateTextToSpeechAsStreamSecurityRequirement0,
            };
        partial void PrepareCreateTextToSpeechAsStreamArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::MiniMax.TextToSpeechRequest request);
        partial void PrepareCreateTextToSpeechAsStreamRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::MiniMax.TextToSpeechRequest request);
        partial void ProcessCreateTextToSpeechAsStreamResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Synthesize speech.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MiniMax.ApiException"></exception>
        public async global::System.Collections.Generic.IAsyncEnumerable<global::MiniMax.TextToSpeechResponse> CreateTextToSpeechAsStreamAsync(

            global::MiniMax.TextToSpeechRequest request,
            global::MiniMax.AutoSDKRequestOptions? requestOptions = default,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            request = new global::MiniMax.TextToSpeechRequest
            {
                Model = request.Model,
                Text = request.Text,
                Stream = true,
                StreamOptions = request.StreamOptions,
                VoiceSetting = request.VoiceSetting,
                AudioSetting = request.AudioSetting,
                PronunciationDict = request.PronunciationDict,
                TimbreWeights = request.TimbreWeights,
                LanguageBoost = request.LanguageBoost,
                VoiceModify = request.VoiceModify,
                SubtitleEnable = request.SubtitleEnable,
                SubtitleType = request.SubtitleType,
                OutputFormat = request.OutputFormat,
                AigcWatermark = request.AigcWatermark,
            };
            PrepareArguments(
                client: HttpClient);
            PrepareCreateTextToSpeechAsStreamArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::MiniMax.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateTextToSpeechAsStreamSecurityRequirements,
                operationName: "CreateTextToSpeechAsStreamAsync");

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
                                servers: s_CreateTextToSpeechAsStreamServers,
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

                __httpRequest.Headers.TryAddWithoutValidation(
                    "Accept",
                    "text/event-stream");

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
                PrepareCreateTextToSpeechAsStreamRequest(
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
                                operationId: "CreateTextToSpeechAsStream",
                                methodName: "CreateTextToSpeechAsStreamAsync",
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
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseHeadersRead,
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
                                operationId: "CreateTextToSpeechAsStream",
                                methodName: "CreateTextToSpeechAsStreamAsync",
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
                                operationId: "CreateTextToSpeechAsStream",
                                methodName: "CreateTextToSpeechAsStreamAsync",
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
                ProcessCreateTextToSpeechAsStreamResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::MiniMax.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::MiniMax.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateTextToSpeechAsStream",
                                methodName: "CreateTextToSpeechAsStreamAsync",
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
                                operationId: "CreateTextToSpeechAsStream",
                                methodName: "CreateTextToSpeechAsStreamAsync",
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

                            try
                            {
                                __response.EnsureSuccessStatusCode();
                            }
                            catch (global::System.Net.Http.HttpRequestException __ex)
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

                                throw global::MiniMax.ApiException.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __ex,
                                    responseBody: __content,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }

                            using var __stream = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                __effectiveCancellationToken
                #endif
                            ).ConfigureAwait(false);

                            await foreach (var __sseEvent in global::System.Net.ServerSentEvents.SseParser
                                .Create(__stream).EnumerateAsync(__effectiveCancellationToken))
                            {
                                var __content = __sseEvent.Data;
                                if (__content == "[DONE]")
                                {
                                    yield break;
                                }

                                var __streamedResponse = global::MiniMax.TextToSpeechResponse.FromJson(__content, JsonSerializerContext) ??
                                                       throw global::MiniMax.ApiException.Create(
                                                           statusCode: __response.StatusCode,
                                                           message: $"Response deserialization failed for \"{__content}\" ",
                                                           innerException: null,
                                                           responseBody: __content,
                                                           responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                                               __response.Headers,
                                                               h => h.Key,
                                                               h => h.Value));

                                yield return __streamedResponse;
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
        /// <summary>
        /// Synthesize speech.
        /// </summary>
        /// <param name="model">
        /// Speech model.
        /// </param>
        /// <param name="text">
        /// Input text.
        /// </param>
        /// <param name="streamOptions"></param>
        /// <param name="voiceSetting"></param>
        /// <param name="audioSetting"></param>
        /// <param name="pronunciationDict"></param>
        /// <param name="timbreWeights"></param>
        /// <param name="languageBoost"></param>
        /// <param name="voiceModify"></param>
        /// <param name="subtitleEnable">
        /// Default Value: false
        /// </param>
        /// <param name="subtitleType">
        /// Default Value: sentence
        /// </param>
        /// <param name="outputFormat">
        /// Default Value: hex
        /// </param>
        /// <param name="aigcWatermark">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Collections.Generic.IAsyncEnumerable<global::MiniMax.TextToSpeechResponse> CreateTextToSpeechAsStreamAsync(
            string model,
            string text,
            global::MiniMax.TtsVoiceSetting voiceSetting,
            global::MiniMax.TtsStreamOptions? streamOptions = default,
            global::MiniMax.TtsAudioSetting? audioSetting = default,
            global::MiniMax.TtsPronunciationDict? pronunciationDict = default,
            global::System.Collections.Generic.IList<global::MiniMax.TimberWeight>? timbreWeights = default,
            global::MiniMax.TextToSpeechRequestLanguageBoost? languageBoost = default,
            global::MiniMax.TtsVoiceModify? voiceModify = default,
            bool? subtitleEnable = default,
            global::MiniMax.TextToSpeechRequestSubtitleType? subtitleType = default,
            global::MiniMax.TextToSpeechRequestOutputFormat? outputFormat = default,
            bool? aigcWatermark = default,
            global::MiniMax.AutoSDKRequestOptions? requestOptions = default,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::MiniMax.TextToSpeechRequest
            {
                Model = model,
                Text = text,
                Stream = true,
                StreamOptions = streamOptions,
                VoiceSetting = voiceSetting,
                AudioSetting = audioSetting,
                PronunciationDict = pronunciationDict,
                TimbreWeights = timbreWeights,
                LanguageBoost = languageBoost,
                VoiceModify = voiceModify,
                SubtitleEnable = subtitleEnable,
                SubtitleType = subtitleType,
                OutputFormat = outputFormat,
                AigcWatermark = aigcWatermark,
            };

            var __enumerable = CreateTextToSpeechAsStreamAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);

            await foreach (var __response in __enumerable)
            {
                yield return __response;
            }
        }
    }
}