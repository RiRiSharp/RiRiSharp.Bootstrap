using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.BaseComponents;
using RiRiSharp.Bootstrap.Components.Accordion.Internals;

namespace RiRiSharp.Bootstrap.Components.Accordion;

public partial class BsAccordionCollapse : BsChildContentComponent
{
    [Parameter] public bool Collapsed { get; set; } = true;
    [CascadingParameter] public BsAccordionItemContext AccordionItemContext { get; set; }
}