using Microsoft.AspNetCore.Components;
using Wader.BaseComponents;

namespace Wader.Content.Tables;

public partial class BsTableData : BsChildContentComponent
{
    protected override string BsComponentClasses => Options.ToBootstrapRowOrDataClass();

    [Parameter]
    public BsTableOptions Options { get; set; }
}
