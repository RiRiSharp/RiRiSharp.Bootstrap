using Microsoft.AspNetCore.Components;
using Wader.BaseComponents;

namespace Wader.Content.Tables;

public partial class BsTable : BsChildContentComponent
{
    protected override string BsComponentClasses => $"table {Options.ToBootstrapTableClass()}";

    [Parameter]
    public BsTableOptions Options { get; set; }
}
