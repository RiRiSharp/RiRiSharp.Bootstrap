using RiRiSharp.Bootstrap.Forms.ChecksRadios;

namespace RiRiSharp.Bootstrap.UnitTests.Forms.ChecksRadios;

public class BsButtonCheckInputCheckboxTests()
    : BsInputBaseComponentTests<BsButtonCheckInputCheckbox, bool>(
        """<input class="btn-check {0}" type="checkbox" {1}/>"""
    )
{
    [Fact]
    public void TrueChecksTheCheckbox()
    {
        // Arrange
        var value = true;

        // Act
        var cut = Render<BsButtonCheckInputCheckbox>(parameters =>
            parameters.Bind(p => p.Value, value, newValue => value = newValue)
        );

        // Assert
        var expectedMarkupString = GetExpectedHtml("", "checked");
        cut.MarkupMatches(expectedMarkupString);
    }

    [Theory]
    [InlineData(false, false, "")]
    [InlineData(true, true, "checked")]
    [InlineData(true, false, "")]
    [InlineData(false, true, "checked")]
    public void CheckingCheckboxSetsCorrectValue(bool beforeValue, bool afterValue, string expectedAttribute)
    {
        // Arrange
        var value = beforeValue;

        // Act
        var cut = Render<BsButtonCheckInputCheckbox>(parameters =>
            parameters.Bind(p => p.Value, value, newValue => value = newValue)
        );
        var inputElement = cut.Find("input");
        inputElement.Change(afterValue);

        // Assert
        var expectedMarkupString = GetExpectedHtml("", expectedAttribute);
        cut.MarkupMatches(expectedMarkupString);
    }
}
