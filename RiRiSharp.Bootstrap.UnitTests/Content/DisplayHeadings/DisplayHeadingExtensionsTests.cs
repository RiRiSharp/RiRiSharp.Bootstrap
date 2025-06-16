using RiRiSharp.Bootstrap.Content.DisplayHeadings;

namespace RiRiSharp.Bootstrap.UnitTests.Content.DisplayHeadings;

public class DisplayHeadingExtensionsTests
{
    [Theory]
    [InlineData(DisplayHeadingType.Display1, "display-1")]
    [InlineData(DisplayHeadingType.Display2, "display-2")]
    [InlineData(DisplayHeadingType.Display3, "display-3")]
    [InlineData(DisplayHeadingType.Display4, "display-4")]
    [InlineData(DisplayHeadingType.Display5, "display-5")]
    [InlineData(DisplayHeadingType.Display6, "display-6")]
    public void DisplayHeadingGeneratesCorrectClass(DisplayHeadingType displayHeadingType, string expectedClass)
    {
        var generatedClass = displayHeadingType.ToBootstrapClass();

        Assert.Equal(expectedClass, generatedClass);
    }
}