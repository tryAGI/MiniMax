using Microsoft.Extensions.AI;

namespace MiniMax;

/// <summary>
/// Extensions for using <see cref="MiniMaxClient"/> as MEAI tools with any <see cref="IChatClient"/>.
/// </summary>
[System.CLSCompliant(false)]
public static class MiniMaxToolExtensions
{
    /// <summary>
    /// Creates an <see cref="AIFunction"/> that submits a Hailuo video
    /// generation task. Returns the created task ID that can be polled via
    /// <see cref="AsGetVideoTaskTool"/>.
    /// </summary>
    /// <param name="client">The MiniMax client.</param>
    /// <param name="model">
    /// Video model (default: <c>MiniMax-Hailuo-2.3</c>). Other values include
    /// <c>MiniMax-Hailuo-2.3-Fast</c>, <c>MiniMax-Hailuo-02</c>,
    /// <c>T2V-01-Director</c>, <c>I2V-01-Director</c>, <c>S2V-01</c>.
    /// </param>
    /// <param name="duration">Video length in seconds (default: 6).</param>
    /// <param name="resolution">Output resolution (default: 1080P).</param>
    public static AIFunction AsCreateVideoTaskTool(
        this MiniMaxClient client,
        string model = "MiniMax-Hailuo-2.3",
        int duration = 6,
        VideoGenerationRequestResolution resolution = VideoGenerationRequestResolution.x1080p)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (
                string prompt,
                string? firstFrameImage,
                string? lastFrameImage,
                CancellationToken cancellationToken) =>
            {
                var response = await client.Video.CreateVideoGenerationTaskAsync(
                    model: model,
                    prompt: prompt,
                    firstFrameImage: firstFrameImage,
                    lastFrameImage: lastFrameImage,
                    duration: duration,
                    resolution: resolution,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatBase(
                    response.BaseResp,
                    successMessage: string.IsNullOrWhiteSpace(response.TaskId)
                        ? "Video generation task created."
                        : $"Video generation task created. task_id: {response.TaskId}");
            },
            name: "CreateVideoTask",
            description: "Submits a Hailuo video generation task to MiniMax. Provide a descriptive prompt; optionally include first_frame_image (image-to-video) or both first/last_frame_image (start-end mode). Returns a task_id to be polled via GetVideoTask.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that polls a video generation task by ID.
    /// </summary>
    public static AIFunction AsGetVideoTaskTool(this MiniMaxClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string taskId, CancellationToken cancellationToken) =>
            {
                var response = await client.Video.GetVideoGenerationTaskAsync(
                    taskId: taskId,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                var parts = new List<string>();
                if (!string.IsNullOrWhiteSpace(response.TaskId))
                {
                    parts.Add($"task_id: {response.TaskId}");
                }
                if (response.Status is { } status)
                {
                    parts.Add($"status: {status.ToValueString()}");
                }
                if (!string.IsNullOrWhiteSpace(response.FileId))
                {
                    parts.Add($"file_id: {response.FileId} (retrieve via Files.RetrieveFileAsync)");
                }
                if (response.BaseResp is { } baseResp && baseResp.StatusCode is not null and not 0)
                {
                    parts.Add($"error: {baseResp.StatusCode} {baseResp.StatusMsg}");
                }

                return parts.Count == 0 ? "No data returned." : string.Join("\n", parts);
            },
            name: "GetVideoTask",
            description: "Queries the status of a MiniMax Hailuo video generation task. Status progresses through Preparing, Queueing, Processing, Success, Fail. On Success, file_id can be fetched via Files.RetrieveFileAsync.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that generates music from a prompt and/or lyrics.
    /// </summary>
    /// <param name="client">The MiniMax client.</param>
    /// <param name="model">Music model (default: <c>music-2.6</c>).</param>
    public static AIFunction AsGenerateMusicTool(
        this MiniMaxClient client,
        string model = "music-2.6")
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (
                string? prompt,
                string? lyrics,
                bool? isInstrumental,
                CancellationToken cancellationToken) =>
            {
                var response = await client.Music.CreateMusicGenerationAsync(
                    model: model,
                    prompt: prompt,
                    lyrics: lyrics,
                    outputFormat: MusicGenerationRequestOutputFormat.Url,
                    isInstrumental: isInstrumental,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                var parts = new List<string>();
                if (response.Data?.Audio is { Length: > 0 } audio)
                {
                    parts.Add($"audio: {audio}");
                }
                if (response.ExtraInfo is { } info)
                {
                    if (info.MusicDuration is { } dur)
                    {
                        parts.Add($"duration_ms: {dur}");
                    }
                    if (info.MusicSampleRate is { } sr)
                    {
                        parts.Add($"sample_rate: {sr}");
                    }
                }
                if (response.BaseResp is { } baseResp && baseResp.StatusCode is not null and not 0)
                {
                    parts.Add($"error: {baseResp.StatusCode} {baseResp.StatusMsg}");
                }

                return parts.Count == 0 ? "No data returned." : string.Join("\n", parts);
            },
            name: "GenerateMusic",
            description: "Generates music using MiniMax music models. Provide a prompt (style/mood/scenario) and/or lyrics. Set is_instrumental=true to skip vocals. Returns a downloadable audio URL.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that synthesizes speech via the T2A v2 endpoint.
    /// </summary>
    /// <param name="client">The MiniMax client.</param>
    /// <param name="model">TTS model (default: <c>speech-2.6-turbo</c>).</param>
    /// <param name="defaultVoiceId">Default voice ID if the caller does not supply one.</param>
    public static AIFunction AsSynthesizeSpeechTool(
        this MiniMaxClient client,
        string model = "speech-2.6-turbo",
        string defaultVoiceId = "male-qn-qingse")
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (
                string text,
                string? voiceId,
                TtsVoiceSettingEmotion? emotion,
                CancellationToken cancellationToken) =>
            {
                var response = await client.Speech.CreateTextToSpeechAsync(
                    model: model,
                    text: text,
                    voiceSetting: new TtsVoiceSetting
                    {
                        VoiceId = string.IsNullOrWhiteSpace(voiceId) ? defaultVoiceId : voiceId,
                        Emotion = emotion,
                    },
                    outputFormat: TextToSpeechRequestOutputFormat.Url,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                var parts = new List<string>();
                if (response.Data?.Audio is { Length: > 0 } audio)
                {
                    parts.Add($"audio: {audio}");
                }
                if (response.ExtraInfo?.AudioLength is { } length)
                {
                    parts.Add($"audio_length_ms: {length}");
                }
                if (response.ExtraInfo?.UsageCharacters is { } chars)
                {
                    parts.Add($"usage_characters: {chars}");
                }
                if (response.BaseResp is { } baseResp && baseResp.StatusCode is not null and not 0)
                {
                    parts.Add($"error: {baseResp.StatusCode} {baseResp.StatusMsg}");
                }

                return parts.Count == 0 ? "No data returned." : string.Join("\n", parts);
            },
            name: "SynthesizeSpeech",
            description: "Synthesizes speech from text using MiniMax T2A v2. Provide text and an optional voice_id and emotion. Returns a downloadable audio URL.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that creates a voice clone from a previously uploaded file.
    /// </summary>
    /// <param name="client">The MiniMax client.</param>
    public static AIFunction AsCloneVoiceTool(this MiniMaxClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (
                string fileId,
                string voiceId,
                string? sampleText,
                CancellationToken cancellationToken) =>
            {
                var response = await client.Speech.CreateVoiceCloneAsync(
                    fileId: fileId,
                    voiceId: voiceId,
                    text: sampleText,
                    needNoiseReduction: true,
                    needVolumeNormalization: true,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                var parts = new List<string> { $"voice_id: {voiceId}" };
                if (!string.IsNullOrWhiteSpace(response.DemoAudio))
                {
                    parts.Add($"demo_audio: {response.DemoAudio}");
                }
                if (response.InputSensitive is true)
                {
                    parts.Add($"input_sensitive: true (type {response.InputSensitiveType})");
                }
                if (response.BaseResp is { } baseResp && baseResp.StatusCode is not null and not 0)
                {
                    parts.Add($"error: {baseResp.StatusCode} {baseResp.StatusMsg}");
                }

                return string.Join("\n", parts);
            },
            name: "CloneVoice",
            description: "Creates a MiniMax voice clone from a previously uploaded reference audio file. Supply the file_id (from /v1/files/upload with purpose=voice_clone), a target voice_id (8-256 alphanumeric chars, letter start), and optional sample text to verify the clone.");
    }

    private static string FormatBase(BaseResponse? baseResp, string successMessage)
    {
        if (baseResp is null || baseResp.StatusCode is null or 0)
        {
            return successMessage;
        }

        return $"error: {baseResp.StatusCode} {baseResp.StatusMsg}";
    }
}
