using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.Forms.ChecksRadios;

namespace RiRiSharp.Bootstrap.UnitTests.Forms.ChecksRadios;

public class BsButtonCheckInputCheckboxTests()
    : BsInputBaseComponentTests<BsButtonCheckInputCheckbox, bool>(
        """<input class="btn-check {0}" type="checkbox" {1}></label>""")
{
    [Fact]
    public void TrueChecksTheCheckbox()
    {
        // Arrange
        using var ctx = new TestContext();
        var value = true;

        // Act
        var cut = ctx.RenderComponent<BsButtonCheckInputCheckbox>(parameters => parameters.Bind(
            p => p.Value, value, newValue => value = newValue));

        // Assert
        var expectedMarkupString = string.Format(HtmlFormat, string.Empty, "checked");
        cut.MarkupMatches(expectedMarkupString);
    }

    [Theory]
    [InlineData(false, true, "checked")]
    [InlineData(true, true, "checked")]
    [InlineData(true, false, "")]
    [InlineData(false, false, "")]
    public void CheckingCheckboxSetsCorrectValue(bool beforeValue, bool afterValue, string expectedAttribute)
    {
        // Arrange
        using var ctx = new TestContext();
        var value = beforeValue;

        // Act
        var cut = ctx.RenderComponent<BsButtonCheckInputCheckbox>(parameters => parameters.Bind(
            p => p.Value, value, newValue => value = newValue));
        var inputElement = cut.Find("input");
        inputElement.Change(new ChangeEventArgs { Value = afterValue });

        // Assert
        var expectedMarkupString = string.Format(HtmlFormat, string.Empty, expectedAttribute);
        cut.MarkupMatches(expectedMarkupString);
    }
}