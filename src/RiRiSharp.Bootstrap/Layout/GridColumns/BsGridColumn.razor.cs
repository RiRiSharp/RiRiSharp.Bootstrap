using RiRiSharp.Bootstrap.BaseComponents;

namespace RiRiSharp.Bootstrap.Layout.GridColumns;

public partial class BsGridColumn : BsChildContentComponent
{
    protected override string BsComponentClasses =>
        $"{ColumnOptionsBootstrapClasses()} {StartOption.ToBootstrapClass()}";
}
