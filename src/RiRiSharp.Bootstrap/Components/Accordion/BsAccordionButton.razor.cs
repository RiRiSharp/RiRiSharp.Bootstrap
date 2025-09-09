using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using RiRiSharp.Bootstrap.BaseComponents;
using RiRiSharp.Bootstrap.Components.Accordion.Internals;

namespace RiRiSharp.Bootstrap.Components.Accordion;

public partial class BsAccordionButton : BsChildContentComponent, IHasCollapseState
{
    private DotNetObjectReference<BsAccordionButton> _dotNetRef;
    private bool _initialCollapse;
    public bool Collapsed { get; set; } = true;

    [CascadingParameter]
    internal BsAccordionItemContext AccordionItemContext { get; set; }

    [Inject]
    private IBsAccordionJsFunctions AccordionJsFunctions { get; set; }

    protected override void OnInitialized()
    {
        base.OnInitialized();
        Collapsed = AccordionItemContext.Collapsed;
        _initialCollapse = Collapsed;
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

    private async Task ToggleAsync()
    {
        await AccordionItemContext.ToggleAsync();
    }

    private string GetInitialCollapsedClass()
    {
        return _initialCollapse ? "collapsed" : "";
    }
}
