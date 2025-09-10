using System.Reflection;
using NSubstitute;
using RiRiSharp.Bootstrap.Forms.ChecksRadios;

namespace RiRiSharp.Bootstrap.UnitTests.Forms.ChecksRadios;

public class BsIndeterminateInputCheckboxTests()
    : BsInputBaseComponentTests<BsIndeterminateInputCheckbox, bool?>(
        """<input class="form-check-input {0}" type="checkbox" {1}></label>"""
    )
{
    private readonly IBsCheckboxJsFunctions _bsCheckboxJsFunctions = Substitute.For<IBsCheckboxJsFunctions>();

    [Fact]
    public async Task IndeterminateInitializationJsCodeGetsExecutedOnce()
    {
        var test = Console.ReadLine();
        // Arrange
        ConfigureTestContext();

        // Act
        var cut = GetCut();

        // Assert
        await _bsCheckboxJsFunctions.ReceivedWithAnyArgs(1).InitializeIndeterminateAsync(cut.Instance.HtmlRef);
    }

    [Theory]
    [InlineData(false, false, "")]
    [InlineData(true, true, "checked")]
    [InlineData(null, null, "")]
    [InlineData(null, true, "checked")]
    [InlineData(true, false, "")]
    [InlineData(false, true, "checked")]
    public void CheckingCheckboxSetsCorrectValue(bool? beforeValue, bool? afterValue, string expectedAttribute)
    {
        // Arrange
        ConfigureTestContext();
        Value = beforeValue;

        // Act
        var cut = GetCut();
        var inputElement = cut.Find("input");
        inputElement.Change(afterValue);

        // Assert
        cut.MarkupMatches(GetExpectedHtml("", expectedAttribute));
    }

    protected override void ConfigureTestContext()
    {
        _ = Services.AddSingleton(_bsCheckboxJsFunctions);
    }
}
