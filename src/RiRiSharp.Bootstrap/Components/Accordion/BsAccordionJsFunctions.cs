using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using RiRiSharp.Bootstrap.Components.Accordion.Internals;
using RiRiSharp.Bootstrap.Internals;

namespace RiRiSharp.Bootstrap.Components.Accordion;

internal class BsAccordionJsFunctions : IBsAccordionJsFunctions, IAsyncDisposable
{
    internal const string JsFileName = "accordionFunctions.js";
    private readonly BsJsObjectReference _bsJsObjectRef;

    public BsAccordionJsFunctions(IJSRuntime jsRuntime)
    {
        _bsJsObjectRef = new BsJsObjectReference(
            jsRuntime,
            $"./_content/{typeof(BsAccordionJsFunctions).Assembly.GetName().Name}/js/{JsFileName}"
        );
    }

    internal const string CollapseAll = "collapseAll";

    public async Task CollapseAllAsync(ElementReference accordionRef)
    {
        await _bsJsObjectRef.InvokeVoidAsync(CollapseAll, accordionRef);
    }

    internal const string ShowAll = "showAll";

    public async Task ShowAllAsync(ElementReference accordionRef)
    {
        await _bsJsObjectRef.InvokeVoidAsync(ShowAll, accordionRef);
    }

    internal const string CollapseAllButOne = "collapseAllButOne";

    public async Task CollapseAllButOneAsync(ElementReference accordionRef, ElementReference accordionItemRef)
    {
        await _bsJsObjectRef.InvokeVoidAsync(CollapseAllButOne, accordionRef, accordionItemRef);
    }

    internal const string Toggle = "toggle";

    public async Task ToggleAsync(ElementReference accordionItemRef, bool alwaysOpen = false)
    {
        await _bsJsObjectRef.InvokeVoidAsync(Toggle, accordionItemRef, alwaysOpen);
    }

    internal const string Show = "show";

    public async Task ShowAsync(ElementReference accordionItemRef, bool alwaysOpen = false)
    {
        await _bsJsObjectRef.InvokeVoidAsync(Show, accordionItemRef, alwaysOpen);
    }

    internal const string Collapse = "collapse";

    public async Task CollapseAsync(ElementReference accordionItemRef)
    {
        await _bsJsObjectRef.InvokeVoidAsync(Collapse, accordionItemRef);
    }

    internal const string RegisterCollapseCallback = "registerCollapseCallback";

    public async Task RegisterCollapseCallbackAsync<T>(ElementReference buttonRef, DotNetObjectReference<T> dotNetRef)
        where T : class, IHasCollapseState
    {
        await _bsJsObjectRef.InvokeVoidAsync(RegisterCollapseCallback, buttonRef, dotNetRef);
    }

    public async ValueTask DisposeAsync()
    {
        if (_bsJsObjectRef is null)
        {
            return;
        }

        await _bsJsObjectRef.DisposeAsync();
    }
}
