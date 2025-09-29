using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.BaseComponents;

namespace RiRiSharp.Bootstrap.Content.Tables;

public partial class BsTableResponsive : BsChildContentComponent
{
    protected override string BsComponentClasses => Breakpoint.ToBootstrapClass();

    [Parameter]
    public BsTableBreakpoint Breakpoint { get; set; }
}
