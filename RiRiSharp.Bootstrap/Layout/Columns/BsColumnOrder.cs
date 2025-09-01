namespace RiRiSharp.Bootstrap.Layout.Columns;

public enum BsColumnOrder
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
    public static string ToBootstrapClass(this BsColumnOrder options)
    {
        return options switch
        {
            BsColumnOrder.Default => "",
            BsColumnOrder.Order1 => "order-1",
            BsColumnOrder.Order2 => "order-2",
            BsColumnOrder.Order3 => "order-3",
            BsColumnOrder.Order4 => "order-4",
            BsColumnOrder.Order5 => "order-5",
            BsColumnOrder.OrderFirst => "order-first",
            BsColumnOrder.OrderLast => "order-last",
            _ => throw new ArgumentOutOfRangeException(nameof(options), options, null)
        };
    }
}