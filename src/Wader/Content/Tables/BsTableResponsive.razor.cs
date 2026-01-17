using Microsoft.AspNetCore.Components;
using Wader.BaseComponents;

namespace Wader.Content.Tables;

public partial class BsTableResponsive : BsChildContentComponent
{
    protected override string BsComponentClasses => Breakpoint.ToBootstrapClass();

    [Parameter]
    public BsTableBreakpoint Breakpoint { get; set; }
}
