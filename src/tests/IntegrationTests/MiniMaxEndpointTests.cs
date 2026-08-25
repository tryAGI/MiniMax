namespace MiniMax.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void Client_ExposesInternationalAndMainlandChinaEndpoints()
    {
        using var client = new MiniMaxClient("test-key");

        MiniMaxClient.DefaultBaseUrl.Should().Be(MiniMaxEndpoints.International.AbsoluteUri);
        client.AvailableServers.Select(server => server.Uri).Should()
            .Contain(MiniMaxEndpoints.International)
            .And.Contain(MiniMaxEndpoints.MainlandChina);

        client.TrySelectServer("https-api-minimaxi-com").Should().BeTrue();
        client.SelectedServer?.Uri.Should().Be(MiniMaxEndpoints.MainlandChina);
    }
}
