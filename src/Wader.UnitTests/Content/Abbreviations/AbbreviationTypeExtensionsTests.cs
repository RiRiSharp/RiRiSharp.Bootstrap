using Wader.Content.Abbreviations;

namespace Wader.UnitTests.Content.Abbreviations;

public class AbbreviationTypeExtensionsTests
{
    [Theory]
    [InlineData(BsAbbreviationType.Default, "")]
    [InlineData(BsAbbreviationType.Initialism, "initialism")]
    public void AbbreviationTypeGeneratesCorrectClass(BsAbbreviationType abbreviationType, string expectedClass)
    {
        var generatedClass = abbreviationType.ToBootstrapClass();

        Assert.Equal(expectedClass, generatedClass);
    }
}
