using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.BaseComponents;
using RiRiSharp.Bootstrap.Components.Accordion.Internals;

namespace RiRiSharp.Bootstrap.Components.Accordion;

public partial class BsAccordion : BsChildContentComponent
{
    private BsAccordionContext _accordionContext;

    [Parameter]
    public bool AlwaysOpen { get; set; } = false;

    [Parameter]
    public BsAccordionDisplayStyle DisplayStyle { get; set; }

    [Inject]
    private IBsAccordionJsFunctions AccordionJsFunctions { get; set; }

    protected override void OnInitialized()
    {
        base.OnInitialized();
        _accordionContext = new BsAccordionContext { AlwaysOpen = AlwaysOpen };
    }

    public async Task CollapseAllAsync()
    {
        await AccordionJsFunctions.CollapseAllAsync(HtmlRef);
    }

    public async Task ShowAllAsync()
    {
        await AccordionJsFunctions.ShowAllAsync(HtmlRef);
    }

    public async Task CollapseAllButOneAsync(BsAccordionItem accordionItem)
    {
        await AccordionJsFunctions.CollapseAllButOneAsync(HtmlRef, accordionItem.HtmlRef);
    }
}
