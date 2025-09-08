using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using RiRiSharp.Bootstrap.Components.Accordion.Internals;
using RiRiSharp.Bootstrap.Internals;

namespace RiRiSharp.Bootstrap.Components.Accordion;

public class BsAccordionJsFunctions : IBsAccordionJsFunctions
{
    internal const string JsFileName = "accordionFunctions.js";
    private readonly BsJsObjectReference _bsJsObjectReference;

    public BsAccordionJsFunctions(IJSRuntime jsRuntime)
    {
        _bsJsObjectReference = new BsJsObjectReference(jsRuntime, $"./_content/{typeof(BsAccordionJsFunctions).Assembly.GetName().Name}/js/{JsFileName}");
    }

    internal const string Toggle = "toggle";
    public async Task ToggleAsync(ElementReference bsAccordionItemReference, bool alwaysOpen = false)
    {
        await _bsJsObjectReference.InvokeVoidAsync(Toggle, bsAccordionItemReference, alwaysOpen);
    }

    internal const string Show = "show";
    public async Task ShowAsync(ElementReference bsAccordionItemReference)
    {
        await _bsJsObjectReference.InvokeVoidAsync(Show, bsAccordionItemReference);
    }

    internal const string Collapse = "collapse";
    public async Task CollapseAsync(ElementReference bsAccordionItemReference)
    {
        await _bsJsObjectReference.InvokeVoidAsync(Collapse, bsAccordionItemReference);
    }

    internal const string RegisterCollapseCallback = "registerCollapseCallback";
    public async Task RegisterCollapseCallbackAsync<T>(ElementReference buttonRef, DotNetObjectReference<T> dotNetRef) where T : class, IHasCollapseState
    {
        await _bsJsObjectReference.InvokeVoidAsync(RegisterCollapseCallback, buttonRef, dotNetRef);
    }
}