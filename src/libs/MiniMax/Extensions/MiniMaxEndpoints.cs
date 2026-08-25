#nullable enable

namespace MiniMax;

/// <summary>Regional MiniMax API endpoints.</summary>
public static class MiniMaxEndpoints
{
    /// <summary>The default endpoint for international MiniMax accounts.</summary>
    public static readonly Uri International = new("https://api.minimax.io/");

    /// <summary>The endpoint for MiniMax accounts registered in mainland China.</summary>
    public static readonly Uri MainlandChina = new("https://api.minimaxi.com/");
}
