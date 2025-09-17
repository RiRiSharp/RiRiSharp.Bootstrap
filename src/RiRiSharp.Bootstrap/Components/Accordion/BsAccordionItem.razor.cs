using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.BaseComponents;
using RiRiSharp.Bootstrap.Components.Accordion.Internals;
using RiRiSharp.Bootstrap.Internals.Exceptions;

namespace RiRiSharp.Bootstrap.Components.Accordion;

public partial class BsAccordionItem : BsChildContentComponent
{
    public IBsAccordionItemContext AccordionItemContext { get; private set; } = null!;

    [Parameter]
    public bool InitialCollapsed { get; set; } = true;

    [CascadingParameter]
    private IBsAccordionContext? AccordionContext { get; set; }

    [Inject]
    private IBsAccordionJsFunctions AccordionFunctions { get; set; } = null!;

    protected override void OnInitialized()
    {
        base.OnInitialized();
        if (AccordionContext is null)
        {
            throw new CascadingParameterNotProvidedException(typeof(IBsAccordionContext));
        }

        AccordionItemContext = new BsAccordionItemContext(this);
    }

    public async Task ToggleAsync()
    {
        await AccordionFunctions.ToggleAsync(HtmlRef, AccordionContext!.AlwaysOpen);
    }

    public async Task ShowAsync()
    {
        await AccordionFunctions.ShowAsync(HtmlRef, AccordionContext!.AlwaysOpen);
    }

    public async Task CollapseAsync()
    {
        await AccordionFunctions.CollapseAsync(HtmlRef);
    }
}
