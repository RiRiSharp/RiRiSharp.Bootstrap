using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.BaseComponents;

namespace RiRiSharp.Bootstrap.Content.Tables;

public partial class BsTableData : BsChildContentComponent
{
    protected override string BsComponentClasses => Options.ToBootstrapRowOrDataClass();

    [Parameter]
    public BsTableOptions Options { get; set; }
}
