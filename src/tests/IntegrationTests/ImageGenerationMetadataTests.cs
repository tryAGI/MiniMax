using System.Text.Json;

namespace MiniMax.IntegrationTests;

[TestClass]
public class ImageGenerationMetadataTests
{
    [TestMethod]
    public void CountsAcceptStringsAndIntegers()
    {
        const string stringCounts = """
                                    {"metadata":{"success_count":"1","failed_count":"0"},"base_resp":{"status_code":0}}
                                    """;
        const string integerCounts = """
                                     {"metadata":{"success_count":1,"failed_count":0},"base_resp":{"status_code":0}}
                                     """;

        var stringResponse = JsonSerializer.Deserialize(
            stringCounts, SourceGenerationContext.Default.ImageGenerationResponse);
        var integerResponse = JsonSerializer.Deserialize(
            integerCounts, SourceGenerationContext.Default.ImageGenerationResponse);

        Assert.AreEqual("1", stringResponse?.Metadata?.SuccessCount?.PickValue2());
        Assert.AreEqual("0", stringResponse?.Metadata?.FailedCount?.PickValue2());
        Assert.AreEqual(1, integerResponse?.Metadata?.SuccessCount?.PickValue1());
        Assert.AreEqual(0, integerResponse?.Metadata?.FailedCount?.PickValue1());
    }
}
