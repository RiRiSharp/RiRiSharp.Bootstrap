using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.BaseComponents;
using RiRiSharp.Bootstrap.Components.Accordion.Internals;
using RiRiSharp.Bootstrap.Internals.Exceptions;

namespace RiRiSharp.Bootstrap.Components.Accordion;

public partial class BsAccordion : BsChildContentComponent
{
    internal ElementReference HtmlRef;
    protected override string BsComponentClasses => $"accordion {DisplayStyle.ToBootstrapClass()}";
    public IBsAccordionContext AccordionContext { get; private set; } = null!;

    [Parameter]
    public bool AlwaysOpen { get; set; }

    [Parameter]
    public BsAccordionDisplayStyle DisplayStyle { get; set; }

    [Inject]
    private IBsAccordionJsFunctions? AccordionJsFunctions { get; set; }

    protected override void OnInitialized()
    {
        base.OnInitialized();
        AccordionContext = new BsAccordionContext { AlwaysOpen = AlwaysOpen };
    }

    public async Task CollapseAllAsync()
    {
        BsJsInteractionNotEnabledException.ThrowIfNull(
            AccordionJsFunctions,
            nameof(AccordionJsFunctions.CollapseAllAsync)
        );
        await AccordionJsFunctions.CollapseAllAsync(HtmlRef);
    }

    public async Task ShowAllAsync()
    {
        BsJsInteractionNotEnabledException.ThrowIfNull(AccordionJsFunctions, nameof(AccordionJsFunctions.ShowAllAsync));
        await AccordionJsFunctions.ShowAllAsync(HtmlRef);
    }

    public async Task CollapseAllButOneAsync(BsAccordionItem accordionItem)
    {
        ArgumentNullException.ThrowIfNull(accordionItem);
        BsJsInteractionNotEnabledException.ThrowIfNull(
            AccordionJsFunctions,
            nameof(AccordionJsFunctions.CollapseAllButOneAsync)
        );
        await AccordionJsFunctions.CollapseAllButOneAsync(HtmlRef, accordionItem.HtmlRef);
    }
}
