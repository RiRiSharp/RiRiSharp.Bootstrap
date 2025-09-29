using RiRiSharp.Bootstrap.Components.Card;
using RiRiSharp.Bootstrap.UnitTests;

namespace RiRiSharp.Bootstrap.UnitTests.Components.Card;

public class BsCardImageTests() : BsComponentTests<BsCardImage>("""<img class="{0}" {1}/>""")
{
    protected override string ClassesForDefaultTests => "card-img-top";
    protected override Dictionary<string, string> AttributesForDefaultTests => [];

    [Theory]
    [InlineData(BsCardImagePosition.Top, "card-img-top")]
    [InlineData(BsCardImagePosition.Bottom, "card-img-bottom")]
    [InlineData(BsCardImagePosition.Overlay, "card-img")]
    public void PositionParameterAppliesCorrectClass(BsCardImagePosition position, string expectedClass)
    {
        // Arrange
        ConfigureTestContext();

        // Act
        var cut = GetCut(parameters => parameters.Add(p => p.Position, position));

        // Assert
        var expectedMarkupString = GetExpectedHtml(expectedClass, AttributesForDefaultTests);
        cut.MarkupMatches(expectedMarkupString);
    }
}
