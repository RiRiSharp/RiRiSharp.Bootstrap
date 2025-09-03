using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.BaseComponents;
using RiRiSharp.Bootstrap.Components.Accordion.Internals;

namespace RiRiSharp.Bootstrap.Components.Accordion;

public partial class BsAccordionCollapse : BsChildContentComponent
{
    private bool _jsOwnsDown;
    private bool _collapsedInner;
    
    [Parameter] public bool Collapsed { get; set; } = true;
    [CascadingParameter] public BsAccordionItemContext AccordionItemContext { get; set; }

    protected override void OnInitialized()
    {
        base.OnInitialized();
        AccordionItemContext.OnShow += ShowAsync;
        AccordionItemContext.OnCollapse += CollapseAsync;
    }
    
    protected override void OnAfterRender(bool firstRender)
    {
        if (!firstRender) return;
        _collapsedInner = Collapsed;
        _jsOwnsDown = true;
    }

    private async Task ShowAsync()
    {
        await Task.Delay(1);
    }
    
    private async Task CollapseAsync()
    {
        await Task.Delay(1);
    }
    
    private string GetShowClass()
    {
        if (_jsOwnsDown) return "";
        return Collapsed ? "" : "show";
    }
}