using RiRiSharp.Bootstrap.Forms;
using RiRiSharp.Bootstrap.Forms.FormControl;

namespace RiRiSharp.Bootstrap.UnitTests.Forms.FormControl;

public class BsInputTextAreaTests()
    : BsInputBaseComponentTests<BsInputTextArea, string>("""<textarea class="form-control {0}" {1}></textarea>""")
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
        cut.MarkupMatches("""<textarea readonly class="form-control-plaintext" value=""/>""");
    }
}
