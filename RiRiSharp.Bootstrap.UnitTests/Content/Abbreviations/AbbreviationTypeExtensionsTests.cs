using System.Diagnostics.CodeAnalysis;
using RiRiSharp.Bootstrap.Content.Abbreviations;

namespace RiRiSharp.Bootstrap.UnitTests.Content.Abbreviations;

public class AbbreviationTypeExtensionsTests
{
    [Theory]
    [InlineData(AbbreviationType.Default, "")]
    [InlineData(AbbreviationType.Initialism, "initialism")]
    [SuppressMessage("Category", "RZ2012", Justification = "This tests tests explicitly for the Type parameter")]
    public void AbbreviationTypeGeneratesCorrectClass(AbbreviationType abbreviationType, string expectedClass)
    {
        var generatedClass = abbreviationType.ToBootstrapClass();
        
        Assert.Equal(expectedClass, generatedClass);
    }
}