using RiRiSharp.Bootstrap.BaseComponents;

namespace RiRiSharp.Bootstrap.Content.Tables;

public partial class BsTableBody : BsChildContentComponent
{
    protected override string BsComponentClasses => TableGroupDivider ? "table-group-divider" : string.Empty;
}
