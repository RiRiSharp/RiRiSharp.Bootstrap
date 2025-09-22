using NSubstitute;
using RiRiSharp.Bootstrap.Forms.ChecksRadios;
using RiRiSharp.Bootstrap.Forms.ChecksRadios.Internals;

namespace RiRiSharp.Bootstrap.UnitTests.Forms.ChecksRadios;

public class BsIndeterminateInputCheckboxTests()
    : BsInputBaseComponentTests<BsIndeterminateInputCheckbox, bool?>(
        """<input class="form-check-input {0}" {1}></label>"""
    )
{
    private readonly IBsCheckboxJsFunctions _bsCheckboxJsFunctions = Substitute.For<IBsCheckboxJsFunctions>();

    protected override Dictionary<string, string> AttributesForDefaultTests => new() { ["type"] = "checkbox" };

    [Fact]
    public async Task IndeterminateInitializationJsCodeGetsExecutedOnceAsync()
    {
        // Arrange
        ConfigureTestContext();

        // Act
        var cut = GetCut();

        // Assert
        await _bsCheckboxJsFunctions.ReceivedWithAnyArgs(1).InitializeIndeterminateAsync(cut.Instance.HtmlRef);
    }

    [Theory]
    [InlineData(false, false, false)]
    [InlineData(true, true, true)]
    [InlineData(null, null, false)]
    [InlineData(null, true, true)]
    [InlineData(true, false, false)]
    [InlineData(false, true, true)]
    public void CheckingCheckboxSetsCorrectValue(bool? beforeValue, bool? afterValue, bool isChecked)
    {
        // Arrange
        ConfigureTestContext();
        Value = beforeValue;
        var attributeDict = AttributesForDefaultTests;
        if (isChecked)
        {
            attributeDict["checked"] = "";
        }

        // Act
        var cut = GetCut();
        var inputElement = cut.Find("input");
        inputElement.Change(afterValue);

        // Assert
        cut.MarkupMatches(GetExpectedHtml("", attributeDict));
    }

    [Fact]
    public void InputTypeCannotBeOverriden()
    {
        TestForDisallowingOverride("type");
    }

    protected override void ConfigureTestContext()
    {
        _ = Services.AddSingleton(_bsCheckboxJsFunctions);
    }
}
