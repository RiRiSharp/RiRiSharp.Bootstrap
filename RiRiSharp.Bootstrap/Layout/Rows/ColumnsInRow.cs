namespace RiRiSharp.Bootstrap.Layout.Rows;

public enum ColumnsInRow
{
    None = 0,
    Cols1 = 1,
    Cols2 = 2,
    Cols3 = 3,
    Cols4 = 4,
    Cols5 = 5,
    Cols6 = 6,
    Cols7 = 7,
    Cols8 = 8,
    Cols9 = 9,
    Cols10 = 10,
    Cols11 = 11,
    Cols12 = 12,
    ColsAuto = 13
}

public static class RowOptsExtensions
{
    public static string ToBootstrapClass(this ColumnsInRow options)
    {
        return options switch
        {
            ColumnsInRow.None => string.Empty,
            ColumnsInRow.Cols1 => "row-cols-1",
            ColumnsInRow.Cols2 => "row-cols-2",
            ColumnsInRow.Cols3 => "row-cols-3",
            ColumnsInRow.Cols4 => "row-cols-4",
            ColumnsInRow.Cols5 => "row-cols-5",
            ColumnsInRow.Cols6 => "row-cols-6",
            ColumnsInRow.Cols7 => "row-cols-7",
            ColumnsInRow.Cols8 => "row-cols-8",
            ColumnsInRow.Cols9 => "row-cols-9",
            ColumnsInRow.Cols10 => "row-cols-10",
            ColumnsInRow.Cols11 => "row-cols-11",
            ColumnsInRow.Cols12 => "row-cols-12",
            ColumnsInRow.ColsAuto => "row-cols-auto",
            _ => throw new ArgumentOutOfRangeException(nameof(options), options, null)
        };
    }
}