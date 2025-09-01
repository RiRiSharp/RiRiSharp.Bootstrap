namespace RiRiSharp.Bootstrap.Layout.GridColumns;

[Flags]
public enum GridStartOptions : long
{
    Default = 0,

    Start1 = 1 << 6,
    Start2 = 1 << 7,
    Start3 = 1 << 8,
    Start4 = 1 << 9,
    Start5 = 1 << 10,
    Start6 = 1 << 11,
    Start7 = 1 << 12,
    Start8 = 1 << 13,
    Start9 = 1 << 14,
    Start10 = 1 << 15,
    Start11 = 1 << 16,
    Start12 = 1 << 17,
}

public static class GridStartOptionsExtensions
{

    public static string ToBootstrapClass(this GridStartOptions gridColumnOptions)
    {
        var classString = "";
        if (gridColumnOptions == GridStartOptions.Default) return classString;

        classString = "g-start";
        classString += gridColumnOptions.ColumnWidth();
        return classString;
    }
    
    private static string ColumnWidth(this GridStartOptions gridColumnOptions)
    {
        if (gridColumnOptions.HasFlag(GridStartOptions.Start1))
        {
            return "-1";
        }

        if (gridColumnOptions.HasFlag(GridStartOptions.Start2))
        {
            return "-2";
        }

        if (gridColumnOptions.HasFlag(GridStartOptions.Start3))
        {
            return "-3";
        }

        if (gridColumnOptions.HasFlag(GridStartOptions.Start4))
        {
            return "-4";
        }

        if (gridColumnOptions.HasFlag(GridStartOptions.Start5))
        {
            return "-5";
        }

        if (gridColumnOptions.HasFlag(GridStartOptions.Start6))
        {
            return "-6";
        }

        if (gridColumnOptions.HasFlag(GridStartOptions.Start7))
        {
            return "-7";
        }

        if (gridColumnOptions.HasFlag(GridStartOptions.Start8))
        {
            return "-8";
        }

        if (gridColumnOptions.HasFlag(GridStartOptions.Start9))
        {
            return "-9";
        }

        if (gridColumnOptions.HasFlag(GridStartOptions.Start10))
        {
            return "-10";
        }

        if (gridColumnOptions.HasFlag(GridStartOptions.Start11))
        {
            return "-11";
        }

        if (gridColumnOptions.HasFlag(GridStartOptions.Start12))
        {
            return "-12";
        }

        return "";
    }
}