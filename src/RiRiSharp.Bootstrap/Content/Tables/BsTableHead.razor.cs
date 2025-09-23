using RiRiSharp.Bootstrap.BaseComponents;

namespace RiRiSharp.Bootstrap.Content.Tables;

public partial class BsTableHead : BsChildContentComponent
{
    protected override string BsComponentClasses => Options.ToBootstrapTableHeadClass();
}
