using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Microsoft.JSInterop.Infrastructure;
using RiRiSharp.Bootstrap.Components.Accordion.Internals;

namespace RiRiSharp.Bootstrap.Components.Accordion;

public interface IBsAccordionJsFunctions
{
    Task CollapseAllAsync(ElementReference accordionRef);
    Task ShowAllAsync(ElementReference accordionRef);
    Task CollapseAllButOneAsync(ElementReference accordionRef, ElementReference accordionItemRef);
    Task ToggleAsync(ElementReference accordionItemRef, bool alwaysOpen = false);
    Task ShowAsync(ElementReference accordionItemRef, bool alwaysOpen = false);
    Task CollapseAsync(ElementReference accordionItemRef);
    Task RegisterCollapseCallbackAsync<T>(
        ElementReference buttonRef,
        DotNetObjectReference<T> dotNetRef
    )
        where T : class, IHasCollapseState;
}
