using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using RiRiSharp.Bootstrap.Components.Accordion.Internals;
using RiRiSharp.Bootstrap.Internals;

namespace RiRiSharp.Bootstrap.Components.Accordion;

internal class BsAccordionJsFunctions : IBsAccordionJsFunctions, IAsyncDisposable
{
    internal const string JS_FILE_NAME = "accordionFunctions.js";
    private readonly BsJsObjectReference _bsJsObjectRef;

    public BsAccordionJsFunctions(IJSRuntime jsRuntime)
    {
        _bsJsObjectRef = new BsJsObjectReference(
            jsRuntime,
            $"./_content/{typeof(BsAccordionJsFunctions).Assembly.GetName().Name}/js/{JS_FILE_NAME}"
        );
    }

    internal const string COLLAPSE_ALL = "collapseAll";

    public async Task CollapseAllAsync(ElementReference accordionRef)
    {
        await _bsJsObjectRef.InvokeVoidAsync(COLLAPSE_ALL, accordionRef);
    }

    internal const string SHOW_ALL = "showAll";

    public async Task ShowAllAsync(ElementReference accordionRef)
    {
        await _bsJsObjectRef.InvokeVoidAsync(SHOW_ALL, accordionRef);
    }

    internal const string COLLAPSE_ALL_BUT_ONE = "collapseAllButOne";

    public async Task CollapseAllButOneAsync(ElementReference accordionRef, ElementReference accordionItemRef)
    {
        await _bsJsObjectRef.InvokeVoidAsync(COLLAPSE_ALL_BUT_ONE, accordionRef, accordionItemRef);
    }

    internal const string TOGGLE = "toggle";

    public async Task ToggleAsync(ElementReference accordionItemRef, bool alwaysOpen = false)
    {
        await _bsJsObjectRef.InvokeVoidAsync(TOGGLE, accordionItemRef, alwaysOpen);
    }

    internal const string SHOW = "show";

    public async Task ShowAsync(ElementReference accordionItemRef, bool alwaysOpen = false)
    {
        await _bsJsObjectRef.InvokeVoidAsync(SHOW, accordionItemRef, alwaysOpen);
    }

    internal const string COLLAPSE = "collapse";

    public async Task CollapseAsync(ElementReference accordionItemRef)
    {
        await _bsJsObjectRef.InvokeVoidAsync(COLLAPSE, accordionItemRef);
    }

    internal const string REGISTER_COLLAPSE_CALLBACK = "registerCollapseCallback";

    public async Task RegisterCollapseCallbackAsync<T>(ElementReference buttonRef, DotNetObjectReference<T> dotNetRef)
        where T : class, IHasCollapseState
    {
        await _bsJsObjectRef.InvokeVoidAsync(REGISTER_COLLAPSE_CALLBACK, buttonRef, dotNetRef);
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
