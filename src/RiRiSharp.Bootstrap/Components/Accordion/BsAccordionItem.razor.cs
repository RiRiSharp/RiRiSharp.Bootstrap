using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.BaseComponents;
using RiRiSharp.Bootstrap.Components.Accordion.Internals;
using RiRiSharp.Bootstrap.Internals;
using RiRiSharp.Bootstrap.Internals.Exceptions;

namespace RiRiSharp.Bootstrap.Components.Accordion;

public partial class BsAccordionItem : BsChildContentComponent, IAsyncDisposable
{
    protected override string BsComponentClasses => "accordion-item";
    public IBsAccordionItemContext AccordionItemContext { get; private set; } = null!;
    internal ElementReference HtmlRef;

    [Parameter]
    public bool InitialCollapsed { get; set; } = true;

    [CascadingParameter]
    private IBsAccordionContext? AccordionContext { get; set; }

    [Inject]
    private IBsAccordionJsFunctions? AccordionJsFunctions { get; set; }

    protected override void OnParametersSet()
    {
        base.OnParametersSet();
        if (AccordionContext is null)
        {
            throw new BsCascadingParameterNotProvidedException(typeof(IBsAccordionContext));
        }

        AccordionItemContext = new BsAccordionItemContext(this);
    }

    public async Task ToggleAsync()
    {
        BsJsInteractionNotEnabledException.ThrowIfNull(AccordionJsFunctions, nameof(AccordionJsFunctions.ToggleAsync));
        await AccordionJsFunctions.ToggleAsync(HtmlRef, AccordionContext!.AlwaysOpen);
    }

    public async Task ShowAsync()
    {
        BsJsInteractionNotEnabledException.ThrowIfNull(AccordionJsFunctions, nameof(AccordionJsFunctions.ShowAsync));
        await AccordionJsFunctions.ShowAsync(HtmlRef, AccordionContext!.AlwaysOpen);
    }

    public async Task CollapseAsync()
    {
        BsJsInteractionNotEnabledException.ThrowIfNull(
            AccordionJsFunctions,
            nameof(AccordionJsFunctions.CollapseAsync)
        );
        await AccordionJsFunctions.CollapseAsync(HtmlRef);
    }

    public async ValueTask DisposeAsync()
    {
        await DisposeAsync(true);
        GC.SuppressFinalize(this);
    }

    private async ValueTask DisposeAsync(bool disposing)
    {
        if (!disposing || AccordionJsFunctions is null)
        {
            return;
        }

        await AccordionJsFunctions.DisposeAsync(HtmlRef);
    }
}
