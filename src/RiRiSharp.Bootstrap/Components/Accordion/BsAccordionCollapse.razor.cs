using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using RiRiSharp.Bootstrap.BaseComponents;
using RiRiSharp.Bootstrap.Components.Accordion.Internals;
using RiRiSharp.Bootstrap.Internals.Exceptions;

namespace RiRiSharp.Bootstrap.Components.Accordion;

public partial class BsAccordionCollapse : BsChildContentComponent, IHasCollapseState
{
    private DotNetObjectReference<BsAccordionCollapse> _dotNetRef = null!;
    private bool _initialCollapse;

    protected override string BsComponentClasses => $"accordion-collapse collapse {GetInitialCollapsedClass()}";
    public bool Collapsed { get; set; } = true;

    [CascadingParameter]
    public IBsAccordionItemContext? AccordionItemContext { get; set; }

    [Inject]
    private IBsAccordionJsFunctions AccordionJsFunctions { get; set; } = null!;

    protected override void OnInitialized()
    {
        base.OnInitialized();
        _initialCollapse = AccordionItemContext!.Collapsed;
    }

    protected override void OnParametersSet()
    {
        base.OnParametersSet();
        if (AccordionItemContext is null)
        {
            throw new BsCascadingParameterNotProvidedException(typeof(IBsAccordionItemContext));
        }
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            _dotNetRef = DotNetObjectReference.Create(this);
            await AccordionJsFunctions.RegisterCollapseCallbackAsync(HtmlRef, _dotNetRef);
        }
    }

    [JSInvokable]
    public void UpdateCollapseState(bool isCollapsed)
    {
        Collapsed = isCollapsed;
        StateHasChanged();
    }

    private string GetInitialCollapsedClass()
    {
        return _initialCollapse ? "" : "show";
    }
}
