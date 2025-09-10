using RiRiSharp.Bootstrap.Forms;
using RiRiSharp.Bootstrap.Forms.FormControl;

namespace RiRiSharp.Bootstrap.UnitTests.Forms.FormControl;

public class BsInputTextTests()
    : BsInputBaseComponentTests<BsInputText, string>("""<input class="form-control {0}" type="text" {1}></input>""")
{
    [Theory]
    [InlineData(BsFormSize.Large, "form-control-lg")]
    [InlineData(BsFormSize.Regular, "")]
    [InlineData(BsFormSize.Small, "form-control-sm")]
    public void PassingParametersRendersIntoCorrectBsClass(BsFormSize formSize, string expected)
    {
        // Arrange
        Value = "";

        // Act
        var cut = GetCut(parameters => parameters.Add(p => p.Size, formSize));

        // Assert
        cut.MarkupMatches(GetExpectedHtml(expected, "value=\"\""));
    }

    [Fact]
    public void PlaintextRendersCorrectly()
    {
        // Arrange
        Value = "";

        // Act
        var cut = GetCut(parameters => parameters.Add(p => p.ReadonlyPlaintext, true));

        // Assert
        cut.MarkupMatches("""<input readonly class="form-control-plaintext" type="text" value=""/>""");
    }
}
