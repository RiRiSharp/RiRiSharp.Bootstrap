using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using RiRiSharp.Bootstrap.BaseComponents;
using RiRiSharp.Bootstrap.Components.Accordion.Internals;

namespace RiRiSharp.Bootstrap.Components.Accordion;

public partial class BsAccordionCollapse : BsChildContentComponent, IHasCollapseState
{
    private ElementReference _accordionCollapseRef;
    private DotNetObjectReference<BsAccordionCollapse> _dotNetRef;
    [Parameter] public bool Collapsed { get; set; } = true;
    [CascadingParameter] public BsAccordionItemContext AccordionItemContext { get; set; }
    [Inject] private IBsAccordionJsFunctions AccordionJsFunctions { get; set; }
    
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            _dotNetRef = DotNetObjectReference.Create(this);
            await AccordionJsFunctions.RegisterCollapseCallbackAsync(_accordionCollapseRef, _dotNetRef);
        }
    }
    
    [JSInvokable]
    public void UpdateCollapseState(bool isCollapsed)
    {
        Collapsed = isCollapsed;
        StateHasChanged();
    }
}