namespace MiniMax.IntegrationTests;

internal static class TestEnvironment
{
    private static readonly Lock Sync = new();
    private static bool _dotenvLoadAttempted;

    internal static string GetRequiredVariable(string name)
    {
        EnsureLocalDotEnvLoaded();

        return Environment.GetEnvironmentVariable(name) is { Length: > 0 } value
            ? value
            : throw new AssertInconclusiveException(
                $"{name} environment variable is not found. " +
                "Set it directly or run tests with MINIMAX_LOAD_DOTENV=1 and a repo-local .env file.");
    }

    internal static void EnsureLocalDotEnvLoaded()
    {
        if (!ShouldLoadDotEnv())
        {
            return;
        }

        lock (Sync)
        {
            if (_dotenvLoadAttempted)
            {
                return;
            }

            _dotenvLoadAttempted = true;

            var envPath = FindRepoRootDotEnvPath();
            if (envPath is null || !File.Exists(envPath))
            {
                return;
            }

            foreach (var line in File.ReadAllLines(envPath))
            {
                var assignment = ParseEnvAssignment(line);
                if (assignment is null)
                {
                    continue;
                }

                var (key, value) = assignment.Value;
                if (Environment.GetEnvironmentVariable(key) is { Length: > 0 })
                {
                    continue;
                }

                Environment.SetEnvironmentVariable(key, value);
            }
        }
    }

    internal static (string Key, string Value)? ParseEnvAssignment(string line)
    {
        var trimmed = line.Trim();
        if (trimmed.Length == 0 || trimmed.StartsWith("#", StringComparison.Ordinal))
        {
            return null;
        }

        if (trimmed.StartsWith("export ", StringComparison.Ordinal))
        {
            trimmed = trimmed["export ".Length..].TrimStart();
        }

        var separatorIndex = trimmed.IndexOf('=');
        if (separatorIndex <= 0)
        {
            return null;
        }

        var key = trimmed[..separatorIndex].Trim();
        if (key.Length == 0)
        {
            return null;
        }

        var value = trimmed[(separatorIndex + 1)..].Trim();
        if (value.Length >= 2 &&
            ((value[0] == '"' && value[^1] == '"') ||
             (value[0] == '\'' && value[^1] == '\'')))
        {
            value = value[1..^1];
        }

        return (key, value);
    }

    private static bool ShouldLoadDotEnv()
    {
        return Environment.GetEnvironmentVariable("MINIMAX_LOAD_DOTENV") is { Length: > 0 } value &&
               (value.Equals("1", StringComparison.OrdinalIgnoreCase) ||
                value.Equals("true", StringComparison.OrdinalIgnoreCase));
    }

    private static string? FindRepoRootDotEnvPath()
    {
        var directory = new DirectoryInfo(AppContext.BaseDirectory);
        while (directory is not null)
        {
            if (Directory.Exists(Path.Combine(directory.FullName, ".git")))
            {
                return Path.Combine(directory.FullName, ".env");
            }

            directory = directory.Parent;
        }

        return null;
    }
}
