using Microsoft.AspNetCore.Components;
using NSubstitute;
using RiRiSharp.Bootstrap.Forms.ChecksRadios;
using System.Threading.Tasks;

namespace RiRiSharp.Bootstrap.UnitTests.Forms.ChecksRadios;

public class BsIndeterminateInputCheckboxTests()
    : BsInputBaseComponentTests<BsIndeterminateInputCheckbox, bool?>(
        """<input class="form-check-input {0}" type="checkbox" {1}></label>""")
{
        private readonly IBsCheckboxJsFunctions _bsCheckboxJsFunctions = Substitute.For<IBsCheckboxJsFunctions>();
        
    [Fact]
    public async Task IndeterminateInitializationJsCodeGetsExecutedOnce()
    {
        // Arrange
        ConfigureTestContext();

        // Act
        _ = Render<BsIndeterminateInputCheckbox>(BuildParameters);
        await _bsCheckboxJsFunctions.ReceivedWithAnyArgs(1).InitializeIndeterminate(Arg.Any<ElementReference>());
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
        var value = beforeValue;

        // Act
        var cut = Render<BsIndeterminateInputCheckbox>(parameters => parameters.Bind(
            p => p.Value, value, newValue => value = newValue));
        var inputElement = cut.Find("input");
        inputElement.Change(afterValue);

        // Assert
        var expectedMarkupString = string.Format(HtmlFormat, "", expectedAttribute);
        cut.MarkupMatches(expectedMarkupString);
    }
    
    protected override void ConfigureTestContext()
    {
        Services.AddSingleton(_bsCheckboxJsFunctions);
    }
}