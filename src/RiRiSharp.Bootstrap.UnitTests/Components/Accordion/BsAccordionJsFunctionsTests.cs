using System.Collections;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using NSubstitute;
using RiRiSharp.Bootstrap.Components.Accordion;
using RiRiSharp.Bootstrap.Components.Accordion.Internals;

namespace RiRiSharp.Bootstrap.UnitTests.Components.Accordion;

public class BsAccordionJsFunctionsTests : BunitContext
{
    private readonly string _jsModulePath =
        $"./_content/{typeof(BsAccordionJsFunctions).Assembly.GetName().Name}/js/{BsAccordionJsFunctions.JS_FILE_NAME}";

    [Fact]
    public async Task ConstructorWorksAsync()
    {
        // Arrange + Act
        try
        {
            await using var x = new BsAccordionJsFunctions(JSInterop.JSRuntime);
        }
        catch (Exception ex)
        {
            // Assert
            Assert.Fail($"Exception of type {ex.GetType()} occured with message {ex.Message}");
            throw;
        }
    }

    [Theory]
    [ClassData(typeof(SingleParameterFunctionsData))]
    internal async Task AllSingleParamJsFunctionsGetCalledExactlyOnceAsync(
        string jsFunctionName,
        Func<IBsAccordionJsFunctions, ElementReference, Task> func
    )
    {
        // Arrange
        var reference = default(ElementReference);
        _ = JSInterop.SetupModule(_jsModulePath).SetupVoid(jsFunctionName, reference).SetVoidResult();
        await using var functions = new BsAccordionJsFunctions(JSInterop.JSRuntime);

        // Act
        await func(functions, reference);

        // Assert
        AssertFunctionNameGetsCalledCorrectly(jsFunctionName);
    }

    [Theory]
    [ClassData(typeof(DualParameterFunctionsData))]
    internal async Task AllDualParamJsFunctionsGetCalledExactlyOnceAsync(
        string jsFunctionName,
        Func<IBsAccordionJsFunctions, ElementReference, Task> func
    )
    {
        // Arrange
        var reference = default(ElementReference);
        _ = JSInterop.SetupModule(_jsModulePath).SetupVoid(jsFunctionName, reference, false).SetVoidResult();
        await using var functions = new BsAccordionJsFunctions(JSInterop.JSRuntime);

        // Act
        await func(functions, reference);

        // Assert
        AssertFunctionNameGetsCalledCorrectly(jsFunctionName);
    }

    [Fact]
    public async Task RegisterCollapseCallbackAsyncCallsCorrectJsFunctionOnceAsync()
    {
        // Arrange
        var reference = default(ElementReference);
        var mockCollapseState = Substitute.For<IHasCollapseState>();
        var dotNetRef = DotNetObjectReference.Create(mockCollapseState);

        const string jsFunctionName = BsAccordionJsFunctions.REGISTER_COLLAPSE_CALLBACK;
        _ = JSInterop.SetupModule(_jsModulePath).SetupVoid(jsFunctionName, reference, dotNetRef).SetVoidResult();

        await using var functions = new BsAccordionJsFunctions(JSInterop.JSRuntime);

        // Act
        await functions.RegisterCollapseCallbackAsync(reference, dotNetRef);

        // Assert
        AssertFunctionNameGetsCalledCorrectly(jsFunctionName);

        dotNetRef.Dispose(); // Clean up
    }

    private void AssertFunctionNameGetsCalledCorrectly(string jsFunctionName)
    {
        _ = Assert.Single(JSInterop.Invocations["import"]);
        _ = Assert.Single(JSInterop.Invocations[jsFunctionName]);
        Assert.Equal(2, JSInterop.Invocations.Count);
    }
}

public sealed class SingleParameterFunctionsData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return
        [
            BsAccordionJsFunctions.COLLAPSE_ALL,
            (Func<IBsAccordionJsFunctions, ElementReference, Task>)((f, r) => f.CollapseAllAsync(r)),
        ];
        yield return
        [
            BsAccordionJsFunctions.SHOW_ALL,
            (Func<IBsAccordionJsFunctions, ElementReference, Task>)((f, r) => f.ShowAllAsync(r)),
        ];
        yield return
        [
            BsAccordionJsFunctions.COLLAPSE,
            (Func<IBsAccordionJsFunctions, ElementReference, Task>)((f, r) => f.CollapseAsync(r)),
        ];
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

public sealed class DualParameterFunctionsData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return
        [
            BsAccordionJsFunctions.TOGGLE,
            (Func<IBsAccordionJsFunctions, ElementReference, Task>)((f, r) => f.ToggleAsync(r)),
        ];
        yield return
        [
            BsAccordionJsFunctions.SHOW,
            (Func<IBsAccordionJsFunctions, ElementReference, Task>)((f, r) => f.ShowAsync(r)),
        ];
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
