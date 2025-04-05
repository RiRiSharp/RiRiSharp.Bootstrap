namespace RiRiSharp.Bootstrap.Core.Layout.Columns;

public enum ColumnOrder
{
    Default,
    Order1,
    Order2,
    Order3,
    Order4,
    Order5,
    OrderFirst,
    OrderLast,
}

public static class ColumnOrderExtensions
{
    public static string ToBootstrapClass(this ColumnOrder options)
    {
        return options switch
        {
            ColumnOrder.Default => string.Empty,
            ColumnOrder.Order1 => "order-1",
            ColumnOrder.Order2 => "order-2",
            ColumnOrder.Order3 => "order-3",
            ColumnOrder.Order4 => "order-4",
            ColumnOrder.Order5 => "order-5",
            ColumnOrder.OrderFirst => "order-first",
            ColumnOrder.OrderLast => "order-last",
            _ => throw new ArgumentOutOfRangeException(nameof(options), options, null)
        };
    }
}