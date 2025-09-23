using RiRiSharp.Bootstrap.BaseComponents;

namespace RiRiSharp.Bootstrap.Content.Tables;

public partial class BsTableData : BsChildContentComponent
{
    protected override string BsComponentClasses => Options.ToBootstrapRowOrDataClass();
}
