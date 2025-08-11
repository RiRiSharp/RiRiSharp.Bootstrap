using Microsoft.AspNetCore.Components;
using NSubstitute;
using NSubstitute.ReceivedExtensions;
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
        using var ctx = new TestContext();
        ConfigureTestContext(ctx);

        // Act
        _ = ctx.RenderComponent<BsIndeterminateInputCheckbox>(BuildParameters);
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
        using var ctx = new TestContext();
        ConfigureTestContext(ctx);
        var value = beforeValue;

        // Act
        var cut = ctx.RenderComponent<BsIndeterminateInputCheckbox>(parameters => parameters.Bind(
            p => p.Value, value, newValue => value = newValue));
        var inputElement = cut.Find("input");
        inputElement.Change(afterValue);

        // Assert
        var expectedMarkupString = string.Format(HtmlFormat, string.Empty, expectedAttribute);
        cut.MarkupMatches(expectedMarkupString);
    }
    
    protected override void ConfigureTestContext(TestContext ctx)
    {
        ctx.Services.AddSingleton(_bsCheckboxJsFunctions);
    }
}