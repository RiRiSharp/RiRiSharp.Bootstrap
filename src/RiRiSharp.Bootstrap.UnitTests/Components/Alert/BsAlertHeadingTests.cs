using RiRiSharp.Bootstrap.Components.Alert;

namespace RiRiSharp.Bootstrap.UnitTests.Components.Alert;

public class BsAlertHeadingTests() : BsComponentTests<BsAlertHeading>("""<h4 class="alert-heading {0}" {1}></h4>""")
{
    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(3)]
    [InlineData(4)]
    [InlineData(5)]
    public void SupplyingHeaderNumberDrawsCorrectHtmlTag(int heading)
    {
        // Arrange
        ConfigureTestContext();

        // Act
        var cut = GetCut(parameters => parameters.Add(x => x.Heading, heading));

        // Assert
        cut.MarkupMatches($"<h{heading} diff:ignoreAttributes></h{heading}>");
    }

    [Theory]
    [InlineData(0)]
    [InlineData(6)]
    [InlineData(-1)]
    [InlineData(int.MaxValue)]
    [InlineData(int.MinValue)]
    public void SupplyingUnsupportedHeadingNumberThrowsOutOfRange(int heading)
    {
        // Arrange
        ConfigureTestContext();

        // Act + Assert
        _ = Assert.Throws<ArgumentOutOfRangeException>(() =>
            GetCut(parameters => parameters.Add(x => x.Heading, heading))
        );
    }
}
