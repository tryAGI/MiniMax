namespace MiniMax.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static MiniMaxClient GetAuthenticatedClient()
    {
        var apiKey = TestEnvironment.GetRequiredVariable("MINIMAX_API_KEY");

        var client = new MiniMaxClient(apiKey);
        
        return client;
    }
}
