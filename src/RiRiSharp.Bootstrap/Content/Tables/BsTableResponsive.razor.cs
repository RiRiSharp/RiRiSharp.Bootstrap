using RiRiSharp.Bootstrap.BaseComponents;

namespace RiRiSharp.Bootstrap.Content.Tables;

public partial class BsTableResponsive : BsChildContentComponent
{
    protected override string BsComponentClasses => Breakpoint.ToBootstrapClass();
}
