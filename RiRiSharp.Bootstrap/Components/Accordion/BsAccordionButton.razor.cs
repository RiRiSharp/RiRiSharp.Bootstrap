using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.BaseComponents;
using RiRiSharp.Bootstrap.Components.Accordion.Internals;

namespace  RiRiSharp.Bootstrap.Components.Accordion;

public partial class BsAccordionButton : BsChildContentComponent
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

    protected override async Task OnParametersSetAsync()
    {
        if (!_jsOwnsDown) return;
        if (Collapsed == _collapsedInner) return;
        
        if (Collapsed)
        {
            await CollapseAsync();
        }
        else
        {
            await ShowAsync();
        }
    }

    private async Task ShowAsync()
    {
        _collapsedInner = true;
        await Task.Delay(1);
    }

    private async Task CollapseAsync()
    {
        _collapsedInner = false;
        await Task.Delay(1);
    }

    private async Task ToggleAsync()
    {
        _collapsedInner = !_collapsedInner;
        await Task.Delay(1);
    }
    
    private string GetCollapsedClass()
    {
        if (_jsOwnsDown) return "";
        return Collapsed ? "collapsed" : "";
    }
}