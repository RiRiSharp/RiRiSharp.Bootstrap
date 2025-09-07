using Microsoft.AspNetCore.Components;

namespace RiRiSharp.Bootstrap.Components.Accordion;

public interface IBsAccordionJsFunctions
{
    Task ShowAsync(ElementReference bsAccordionItemReference);
    Task CollapseAsync(ElementReference bsAccordionItemReference);
    Task ToggleAsync(ElementReference bsAccordionItemReference);
}