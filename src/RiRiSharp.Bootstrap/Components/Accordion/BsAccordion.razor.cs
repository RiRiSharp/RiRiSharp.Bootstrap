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

    public async Task ShowAllAsync()
    {
        await _accordionContext.ShowAllItemAsync();
    }

    public async Task CollapseAllAsync()
    {
        await _accordionContext.CollapseAllItemsAsync();
    }

    public async Task ShowExactlyOne(BsAccordionItem exceptionItem)
    {
        await _accordionContext.CollapseAllItemsAsync();
        await _accordionContext.ShowItemAsync(exceptionItem);
    }
}