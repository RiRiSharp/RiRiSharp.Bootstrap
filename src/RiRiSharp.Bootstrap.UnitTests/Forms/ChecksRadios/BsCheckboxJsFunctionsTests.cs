using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.Forms.ChecksRadios;

namespace RiRiSharp.Bootstrap.UnitTests.Forms.ChecksRadios;

public class BsCheckboxJsFunctionsTests : BunitContext
{
    [Fact]
    public async Task InitializationCallsImportAsync()
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
    public async Task CallingInitializeIndeterminateCallsCorrectJsFunctionOnceAsync()
    {
        // Arrange
        var reference = default(ElementReference);
        var jsModulePath =
            $"./_content/{typeof(BsCheckboxJsFunctions).Assembly.GetName().Name}/js/{BsCheckboxJsFunctions.JS_FILE_NAME}";
        const string jsFunctionName = BsCheckboxJsFunctions.INIT_INDETERMINATE_JS_FUNCTION_NAME;
        _ = JSInterop.SetupModule(jsModulePath).SetupVoid(jsFunctionName, reference).SetVoidResult();
        await using var functions = new BsCheckboxJsFunctions(JSInterop.JSRuntime);

        // Act
        await functions.InitializeIndeterminateAsync(reference);

        // Assert
        _ = Assert.Single(JSInterop.Invocations["import"]);
        _ = Assert.Single(JSInterop.Invocations[jsFunctionName]);
        Assert.Equal(2, JSInterop.Invocations.Count);
    }
}
