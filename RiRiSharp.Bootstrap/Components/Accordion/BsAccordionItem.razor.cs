using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.BaseComponents;
using RiRiSharp.Bootstrap.Components.Accordion.Internals;

namespace RiRiSharp.Bootstrap.Components.Accordion;

public partial class BsAccordionItem : BsChildContentComponent
{
    private BsAccordionItemContext _accordionItemContext = new();
    [CascadingParameter] public BsAccordionContext AccordionContext { get; set; }

    protected override void OnInitialized()
    {
        base.OnInitialized();
        _accordionItemContext = new BsAccordionItemContext();
        AccordionContext.OnShow[this] += ShowAsync;
        AccordionContext.OnCollapse[this] += CollapseAsync;
    }

    private async Task ShowAsync()
    {
        await _accordionItemContext.Show();
    }

    private async Task CollapseAsync()
    {
        await _accordionItemContext.Collapse();
    }
}