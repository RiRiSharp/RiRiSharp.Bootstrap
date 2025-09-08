using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Microsoft.JSInterop.Infrastructure;
using RiRiSharp.Bootstrap.Components.Accordion.Internals;

namespace RiRiSharp.Bootstrap.Components.Accordion;

public interface IBsAccordionJsFunctions
{
    Task ToggleAsync(ElementReference bsAccordionItemReference, bool alwaysOpen = false);
    Task ShowAsync(ElementReference bsAccordionItemReference);
    Task CollapseAsync(ElementReference bsAccordionItemReference);
    Task RegisterCollapseCallbackAsync<T>(ElementReference buttonRef, DotNetObjectReference<T> dotNetRef) where T : class, IHasCollapseState;
}