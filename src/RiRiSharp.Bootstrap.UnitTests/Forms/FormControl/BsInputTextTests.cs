using RiRiSharp.Bootstrap.Forms;
using RiRiSharp.Bootstrap.Forms.FormControl;

namespace RiRiSharp.Bootstrap.UnitTests.Forms.FormControl;

public class BsInputTextTests() : BsInputBaseComponentTests<BsInputText, string?>("""<input class="{0}" {1}></input>""")
{
    protected override string ClassesForDefaultTests => "form-control";
    protected override Dictionary<string, string> AttributesForDefaultTests => new() { ["type"] = "text" };

    [Theory]
    [InlineData(BsFormSize.Large, "form-control-lg")]
    [InlineData(BsFormSize.Regular, "")]
    [InlineData(BsFormSize.Small, "form-control-sm")]
    public void PassingParametersRendersIntoCorrectBsClass(BsFormSize formSize, string expected)
    {
        // Arrange + Act
        var cut = GetCut(parameters => parameters.Add(p => p.Size, formSize));

        // Assert
        cut.MarkupMatches(GetExpectedHtml($"{expected} {ClassesForDefaultTests}", AttributesForDefaultTests));
    }

    [Fact]
    public void PlaintextRendersCorrectly()
    {
        // Arrange
        var attributeDict = AttributesForDefaultTests;
        attributeDict["readonly"] = "";

        // Act
        var cut = GetCut(parameters => parameters.Add(p => p.ReadonlyPlaintext, true));

        // Assert
        cut.MarkupMatches(GetExpectedHtml("form-control-plaintext", attributeDict));
    }

    [Fact]
    public void InputTypeCannotBeOverriden()
    {
        TestForDisallowingOverride("type");
    }
}
