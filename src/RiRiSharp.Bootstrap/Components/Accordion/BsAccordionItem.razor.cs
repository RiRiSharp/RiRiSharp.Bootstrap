using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.BaseComponents;
using RiRiSharp.Bootstrap.Components.Accordion.Internals;

namespace RiRiSharp.Bootstrap.Components.Accordion;

public partial class BsAccordionItem : BsChildContentComponent
{
    private BsAccordionItemContext _accordionItemContext;

    [Parameter] public bool InitialCollapsed { get; set; } = true;
    [Inject] private IBsAccordionJsFunctions AccordionFunctions { get; set; }
    [CascadingParameter] private BsAccordionContext AccordionContext { get; set; }

    protected override void OnInitialized()
    {
        base.OnInitialized();
        _accordionItemContext = new BsAccordionItemContext(this);
    }

    public async Task ToggleAsync()
    {
        await AccordionFunctions.ToggleAsync(htmlRef, AccordionContext.AlwaysOpen);
    }

    public async Task ShowAsync()
    {
        await AccordionFunctions.ShowAsync(htmlRef, AccordionContext.AlwaysOpen);
    }

    public async Task CollapseAsync()
    {
        await AccordionFunctions.CollapseAsync(htmlRef);
    }
}