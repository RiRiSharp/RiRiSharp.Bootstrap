using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.BaseComponents;
using RiRiSharp.Bootstrap.Components.Accordion.Internals;

namespace RiRiSharp.Bootstrap.Components.Accordion;

public partial class BsAccordion : BsChildContentComponent
{
    private BsAccordionContext _accordionContext;
    
    [Parameter] public BsAccordionDisplayStyle DisplayStyle { get; set; }

    protected override void OnInitialized()
    {
        base.OnInitialized();
        _accordionContext = new BsAccordionContext();
    }

    public async Task CollapseAllAsync()
    {
        await Task.WhenAll(_accordionContext.Items.Select(i => i.CollapseAsync()));
    }

    public async Task ShowAllAsync()
    {
        await Task.WhenAll(_accordionContext.Items.Select(i => i.ShowAsync()));
    }

    public async Task ShowExactlyOne(BsAccordionItem exceptionItem)
    {
        await Task.WhenAll(_accordionContext.Items.Where(i => i != exceptionItem).Select(i => i.CollapseAsync()));
        await exceptionItem.ShowAsync();
    }
}