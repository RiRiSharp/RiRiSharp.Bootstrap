using RiRiSharp.Bootstrap.Core.Content.Headings;

namespace RiRiSharp.Bootstrap.Core.UnitTests.Content.Headings;

public class VirtualHeadingExtensionsTests
{
    [Theory]
    [InlineData(HeadingType.H1, "h1")]
    [InlineData(HeadingType.H2, "h2")]
    [InlineData(HeadingType.H3, "h3")]
    [InlineData(HeadingType.H4, "h4")]
    [InlineData(HeadingType.H5, "h5")]
    [InlineData(HeadingType.H6, "h6")]
    public void HeadingTypeGeneratesCorrectClass(HeadingType displayHeadingType, string expectedClass)
    {
        var generatedClass = displayHeadingType.ToBootstrapClass();

        Assert.Equal(expectedClass, generatedClass);
    }
}