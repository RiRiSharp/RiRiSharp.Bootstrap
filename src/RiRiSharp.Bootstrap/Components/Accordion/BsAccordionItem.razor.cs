using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.BaseComponents;
using RiRiSharp.Bootstrap.Components.Accordion.Internals;

namespace RiRiSharp.Bootstrap.Components.Accordion;

public partial class BsAccordionItem : BsChildContentComponent
{
    private BsAccordionItemContext _accordionItemContext;
    private ElementReference _bsAccordionItem;
    [Inject] private IBsAccordionJsFunctions JsFunctions { get; set; }
    [CascadingParameter] private BsAccordionContext AccordionContext { get; set; }

    protected override void OnInitialized()
    {
        base.OnInitialized();
        _accordionItemContext = new BsAccordionItemContext(this);
    }

    private async Task ShowAsync()
    {
        await JsFunctions.ShowAsync(_bsAccordionItem);
    }

    private async Task CollapseAsync()
    {
        await JsFunctions.CollapseAsync(_bsAccordionItem);
    }

    public async Task ToggleAsync()
    {
        await JsFunctions.ToggleAsync(_bsAccordionItem);
    }
}