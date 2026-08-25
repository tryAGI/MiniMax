namespace MiniMax.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static MiniMaxClient GetAuthenticatedClient()
    {
        var apiKey = TestEnvironment.GetRequiredVariable("MINIMAX_API_KEY");
        var baseUri =
            Environment.GetEnvironmentVariable("MINIMAX_BASE_URL") is { Length: > 0 } baseUrlValue
                ? new Uri(baseUrlValue)
                : MiniMaxEndpoints.International;

        var client = new MiniMaxClient(apiKey, baseUri: baseUri);
        
        return client;
    }
}
