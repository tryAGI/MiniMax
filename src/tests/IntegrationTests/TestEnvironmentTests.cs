namespace MiniMax.IntegrationTests;

[TestClass]
public sealed class TestEnvironmentTests
{
    [TestMethod]
    [DataRow("MINIMAX_API_KEY=test-key", "MINIMAX_API_KEY", "test-key")]
    [DataRow(" export MINIMAX_API_KEY = spaced-value ", "MINIMAX_API_KEY", "spaced-value")]
    [DataRow("MINIMAX_API_KEY=\"quoted value\"", "MINIMAX_API_KEY", "quoted value")]
    [DataRow("MINIMAX_API_KEY='single quoted value'", "MINIMAX_API_KEY", "single quoted value")]
    public void ParseEnvAssignment_ReturnsExpectedKeyAndValue(
        string line,
        string expectedKey,
        string expectedValue)
    {
        var assignment = TestEnvironment.ParseEnvAssignment(line);

        assignment.Should().NotBeNull();
        assignment!.Value.Key.Should().Be(expectedKey);
        assignment.Value.Value.Should().Be(expectedValue);
    }

    [TestMethod]
    [DataRow("")]
    [DataRow("   ")]
    [DataRow("# comment")]
    [DataRow("export")]
    [DataRow("missing_separator")]
    [DataRow("=missing-key")]
    public void ParseEnvAssignment_IgnoresUnsupportedLines(string line)
    {
        var assignment = TestEnvironment.ParseEnvAssignment(line);

        assignment.Should().BeNull();
    }
}
