using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using RiRiSharp.Bootstrap.BaseComponents;
using RiRiSharp.Bootstrap.Components.Accordion.Internals;
using RiRiSharp.Bootstrap.Internals.Exceptions;

namespace RiRiSharp.Bootstrap.Components.Accordion;

public partial class BsAccordionButton : BsChildContentComponent, IHasCollapseState
{
    /// <summary>
    /// Holds a reference to this component for JS interop. Initialized after first render.
    /// </summary>
    private DotNetObjectReference<BsAccordionButton> _dotNetRef = null!;

    private bool _initialCollapse;

    [CascadingParameter]
    internal IBsAccordionItemContext? AccordionItemContext { get; set; }

    [Inject]
    private IBsAccordionJsFunctions AccordionJsFunctions { get; set; } = null!;

    protected override void OnInitialized()
    {
        base.OnInitialized();
        if (AccordionItemContext is null)
        {
            throw new CascadingParameterNotProvidedException(typeof(IBsAccordionItemContext));
        }

        _initialCollapse = AccordionItemContext.Collapsed;
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
        StateHasChanged();
    }

    private async Task ToggleAsync()
    {
        await AccordionItemContext!.ToggleAsync(); // Called after initialization
    }

    private string GetInitialCollapsedClass()
    {
        return _initialCollapse ? "collapsed" : "";
    }
}
