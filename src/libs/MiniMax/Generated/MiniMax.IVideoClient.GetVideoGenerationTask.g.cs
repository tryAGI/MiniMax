#nullable enable

namespace MiniMax
{
    public partial interface IVideoClient
    {
        /// <summary>
        /// Query a video generation task.<br/>
        /// Polls a video generation task by `task_id`. The response `status`<br/>
        /// progresses through `Preparing`, `Queueing`, `Processing`,<br/>
        /// `Success`, `Fail`. When `Success`, `file_id` can be used with<br/>
        /// `GET /v1/files/retrieve`.
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MiniMax.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::MiniMax.VideoTaskStatusResponse> GetVideoGenerationTaskAsync(
            string taskId,
            global::MiniMax.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}