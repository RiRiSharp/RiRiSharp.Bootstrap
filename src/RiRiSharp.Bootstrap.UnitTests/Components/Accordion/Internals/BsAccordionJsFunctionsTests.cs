using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using NSubstitute;
using RiRiSharp.Bootstrap.Components.Accordion;
using RiRiSharp.Bootstrap.Components.Accordion.Internals;

namespace RiRiSharp.Bootstrap.UnitTests.Components.Accordion.Internals;

public class BsAccordionJsFunctionsTests : BunitContext
{
    [Fact]
    public async Task CollapseAllCallsCorrectJsFunctionAsync()
    {
        // Arrange
        var jsObj = Substitute.For<IJSObjectReference>();
        await using var sut = new BsAccordionJsFunctions(jsObj);
        ElementReference accordionRef = default;

        // Act
        await sut.CollapseAllAsync(accordionRef);

        // Assert
        AssertJsInterop.Calls(jsObj, BsAccordionJsFunctions.COLLAPSE_ALL, accordionRef);
    }

    [Fact]
    public async Task ShowAllCallsCorrectJsFunctionAsync()
    {
        // Arrange
        var jsObj = Substitute.For<IJSObjectReference>();
        await using var sut = new BsAccordionJsFunctions(jsObj);
        ElementReference accordionRef = default;

        // Act
        await sut.ShowAllAsync(accordionRef);

        // Assert
        AssertJsInterop.Calls(jsObj, BsAccordionJsFunctions.SHOW_ALL, accordionRef);
    }

    [Fact]
    public async Task CollapseAllButOneCallsCorrectJsFunctionAsync()
    {
        // Arrange
        var jsObj = Substitute.For<IJSObjectReference>();
        await using var sut = new BsAccordionJsFunctions(jsObj);
        ElementReference accordionRef = default;
        ElementReference itemRef = default;

        // Act
        await sut.CollapseAllButOneAsync(accordionRef, itemRef);

        // Assert
        AssertJsInterop.Calls(jsObj, BsAccordionJsFunctions.COLLAPSE_ALL_BUT_ONE, accordionRef, itemRef);
    }

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public async Task ToggleCallsCorrectJsFunctionAsync(bool alwaysOpen)
    {
        // Arrange
        var jsObj = Substitute.For<IJSObjectReference>();
        await using var sut = new BsAccordionJsFunctions(jsObj);
        ElementReference itemRef = default;

        // Act
        await sut.ToggleAsync(itemRef, alwaysOpen);

        // Assert
        AssertJsInterop.Calls(jsObj, BsAccordionJsFunctions.TOGGLE, itemRef, alwaysOpen);
    }

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public async Task ShowCallsCorrectJsFunctionAsync(bool alwaysOpen)
    {
        // Arrange
        var jsObj = Substitute.For<IJSObjectReference>();
        await using var sut = new BsAccordionJsFunctions(jsObj);
        ElementReference itemRef = default;

        // Act
        await sut.ShowAsync(itemRef, alwaysOpen);

        // Assert
        AssertJsInterop.Calls(jsObj, BsAccordionJsFunctions.SHOW, itemRef, alwaysOpen);
    }

    [Fact]
    public async Task CollapseCallsCorrectJsFunctionAsync()
    {
        // Arrange
        var jsObj = Substitute.For<IJSObjectReference>();
        await using var sut = new BsAccordionJsFunctions(jsObj);
        ElementReference itemRef = default;

        // Act
        await sut.CollapseAsync(itemRef);

        // Assert
        AssertJsInterop.Calls(jsObj, BsAccordionJsFunctions.COLLAPSE, itemRef);
    }

    [Fact]
    public async Task RegisterCollapseCallbackCallsCorrectJsFunctionAsync()
    {
        // Arrange
        var jsObj = Substitute.For<IJSObjectReference>();
        await using var sut = new BsAccordionJsFunctions(jsObj);
        ElementReference buttonRef = default;
        using var dotNetRef = DotNetObjectReference.Create(Substitute.For<IHasCollapseState>());

        // Act
        await sut.RegisterCollapseCallbackAsync(buttonRef, dotNetRef);

        // Assert
        AssertJsInterop.Calls(jsObj, BsAccordionJsFunctions.REGISTER_COLLAPSE_CALLBACK, buttonRef, dotNetRef);
    }

    [Fact]
    public async Task JsDisposingCallsCorrectJsFunctionAsync()
    {
        // Arrange
        var jsObj = Substitute.For<IJSObjectReference>();
        await using var sut = new BsAccordionJsFunctions(jsObj);
        ElementReference accordionItemRef = default;

        // Act
        await sut.DisposeAsync(accordionItemRef);

        // Assert
        AssertJsInterop.Calls(jsObj, BsAccordionJsFunctions.DISPOSE, accordionItemRef);
    }
}
