using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using NSubstitute;
using Wader.Forms.ChecksRadios.Internals;

namespace Wader.UnitTests.Forms.ChecksRadios.Internals;

public class BsCheckboxJsFunctionsTests : BunitContext
{
    [Fact]
    public async Task CallingInitializeIndeterminateCallsCorrectJsFunctionOnceAsync()
    {
        // Arrange
        var jsObj = Substitute.For<IJSObjectReference>();
        await using var sut = new BsCheckboxJsFunctions(jsObj);
        ElementReference checkboxRef = default;

        // Act
        await sut.InitializeIndeterminateAsync(checkboxRef);

        // Assert
        AssertJsInterop.Calls(jsObj, BsCheckboxJsFunctions.INITIALIZE_INDETERMINATE, checkboxRef);
    }
}
