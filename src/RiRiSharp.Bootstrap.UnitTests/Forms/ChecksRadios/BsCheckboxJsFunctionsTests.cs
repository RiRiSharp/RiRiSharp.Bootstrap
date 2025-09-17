using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.Forms.ChecksRadios;

namespace RiRiSharp.Bootstrap.UnitTests.Forms.ChecksRadios;

public class BsCheckboxJsFunctionsTests : BunitContext
{
    [Fact]
    public async Task ConstructorWorksAsync()
    {
        // Arrange + Act
        try
        {
            await using var x = new BsCheckboxJsFunctions(JSInterop.JSRuntime);
        }
        catch (Exception ex)
        {
            // Assert
            Assert.Fail($"Exception of type {ex.GetType()} occured with message {ex.Message}");
            throw;
        }
    }

    [Fact]
    public async Task CallingInitializeIndeterminateDoesNotThrowExceptionAsync()
    {
        // Arrange
        var reference = default(ElementReference);

        _ = JSInterop
            .SetupModule(
                $"./_content/{typeof(BsCheckboxJsFunctions).Assembly.GetName().Name}/js/{BsCheckboxJsFunctions.JS_FILE_NAME}"
            )
            .SetupVoid(BsCheckboxJsFunctions.INIT_INDETERMINATE_JS_FUNCTION_NAME, reference)
            .SetVoidResult();

        await using var functions = new BsCheckboxJsFunctions(JSInterop.JSRuntime);

        // Act
        try
        {
            await functions.InitializeIndeterminateAsync(reference);
        }
        catch (Exception ex)
        {
            // Assert
            Assert.Fail($"Exception of type {ex.GetType()} occured with message {ex.Message}");
            throw;
        }
    }
}
