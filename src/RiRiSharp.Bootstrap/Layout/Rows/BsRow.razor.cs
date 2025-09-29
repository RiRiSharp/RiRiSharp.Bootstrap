using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.BaseComponents;

namespace RiRiSharp.Bootstrap.Layout.Rows;

public partial class BsRow : BsChildContentComponent
{
    protected override string BsComponentClasses => $"row {ColumnsInRow.ToBootstrapClass()}";

    [Parameter]
    public BsColumnsInRow ColumnsInRow { get; set; }
}
