using RiRiSharp.Bootstrap.BaseComponents;

namespace RiRiSharp.Bootstrap.Layout.Columns;

public partial class BsColumn : BsChildContentComponent
{
    protected override string BsComponentClasses =>
        $"{ColumnOptionsBootstrapClasses()} {ColumnOffsetBootstrapClasses()} {ColumnOrder.ToBootstrapClass()}";
}
