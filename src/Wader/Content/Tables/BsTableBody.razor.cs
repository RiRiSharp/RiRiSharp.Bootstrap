using Microsoft.AspNetCore.Components;
using Wader.BaseComponents;

namespace Wader.Content.Tables;

public partial class BsTableBody : BsChildContentComponent
{
    protected override string BsComponentClasses => TableGroupDivider ? "table-group-divider" : string.Empty;

    [Parameter]
    public bool TableGroupDivider { get; set; }
}
