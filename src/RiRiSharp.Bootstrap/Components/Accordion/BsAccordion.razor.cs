using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.BaseComponents;
using RiRiSharp.Bootstrap.Components.Accordion.Internals;

namespace RiRiSharp.Bootstrap.Components.Accordion;

public partial class BsAccordion : BsChildContentComponent
{
    private BsAccordionContext _accordionContext;

    [Parameter] public bool AlwaysOpen { get; set; } = false;
    [Parameter] public BsAccordionDisplayStyle DisplayStyle { get; set; }

    protected override void OnInitialized()
    {
        base.OnInitialized();
        _accordionContext = new BsAccordionContext { AlwaysOpen = AlwaysOpen };
    }
}