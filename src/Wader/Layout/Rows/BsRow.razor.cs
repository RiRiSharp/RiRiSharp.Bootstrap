using Microsoft.AspNetCore.Components;
using Wader.BaseComponents;

namespace Wader.Layout.Rows;

public partial class BsRow : BsChildContentComponent
{
    protected override string BsComponentClasses => $"row {ColumnsInRow.ToBootstrapClass()}";

    [Parameter]
    public BsColumnsInRow ColumnsInRow { get; set; }
}
