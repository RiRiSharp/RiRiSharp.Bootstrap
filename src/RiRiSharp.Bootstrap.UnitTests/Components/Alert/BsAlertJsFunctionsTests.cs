using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using NSubstitute;
using RiRiSharp.Bootstrap.Components.Alert;
using RiRiSharp.Bootstrap.Components.Alert.Internals;

namespace RiRiSharp.Bootstrap.UnitTests.Components.Alert;

public class BsAlertJsFunctionsTests
{
    [Fact]
    public async Task DismissCallsCorrectJsFunctionAsync()
    {
        // Arrange
        var jsObj = Substitute.For<IJSObjectReference>();
        await using var sut = new BsAlertJsFunctions(jsObj);
        ElementReference alertRef = default;

        // Act
        await sut.DismissAsync(alertRef);

        // Assert
        AssertJsInterop.Calls(jsObj, BsAlertJsFunctions.DISMISS, alertRef);
    }

    [Fact]
    public async Task RegisterDismissCallbackCallsCorrectJsFunctionAsync()
    {
        // Arrange
        var jsObj = Substitute.For<IJSObjectReference>();
        await using var sut = new BsAlertJsFunctions(jsObj);
        ElementReference alertRef = default;
        using var dotNetRef = DotNetObjectReference.Create(new BsAlert());

        // Act
        await sut.RegisterDismissCallbackAsync(alertRef, dotNetRef);

        // Assert
        AssertJsInterop.Calls(jsObj, BsAlertJsFunctions.REGISTER_DISMISS_CALLBACK, alertRef, dotNetRef);
    }
}
