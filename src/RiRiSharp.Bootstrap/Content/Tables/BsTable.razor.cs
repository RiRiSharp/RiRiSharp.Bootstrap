using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.BaseComponents;

namespace RiRiSharp.Bootstrap.Content.Tables;

public partial class BsTable : BsChildContentComponent
{
    protected override string BsComponentClasses => $"table {Options.ToBootstrapTableClass()}";

    [Parameter]
    public BsTableOptions Options { get; set; }
}
