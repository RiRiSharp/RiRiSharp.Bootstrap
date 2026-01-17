using Microsoft.AspNetCore.Components;
using Wader.BaseComponents;

namespace Wader.Content.Tables;

public partial class BsTableHead : BsChildContentComponent
{
    protected override string BsComponentClasses => Options.ToBootstrapTableHeadClass();

    [Parameter]
    public BsTableOptions Options { get; set; }
}
