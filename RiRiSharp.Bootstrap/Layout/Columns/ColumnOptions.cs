namespace RiRiSharp.Bootstrap.Layout.Columns;

[Flags]
public enum ColumnOptions : long
{
    Default = 0,
    Sm = 1 << 1,
    Md = 1 << 2,
    Lg = 1 << 3,
    Xl = 1 << 4,
    Xxl = 1 << 5,

    Col1 = 1 << 6,
    Col2 = 1 << 7,
    Col3 = 1 << 8,
    Col4 = 1 << 9,
    Col5 = 1 << 10,
    Col6 = 1 << 11,
    Col7 = 1 << 12,
    Col8 = 1 << 13,
    Col9 = 1 << 14,
    Col10 = 1 << 15,
    Col11 = 1 << 16,
    Col12 = 1 << 17,
    ColAuto = 1 << 18,

    ColSm1 = Sm | Col1,
    ColSm2 = Sm | Col2,
    ColSm3 = Sm | Col3,
    ColSm4 = Sm | Col4,
    ColSm5 = Sm | Col5,
    ColSm6 = Sm | Col6,
    ColSm7 = Sm | Col7,
    ColSm8 = Sm | Col8,
    ColSm9 = Sm | Col9,
    ColSm10 = Sm | Col10,
    ColSm11 = Sm | Col11,
    ColSm12 = Sm | Col12,
    ColSmAuto = Sm | ColAuto,

    ColMd1 = Md | Col1,
    ColMd2 = Md | Col2,
    ColMd3 = Md | Col3,
    ColMd4 = Md | Col4,
    ColMd5 = Md | Col5,
    ColMd6 = Md | Col6,
    ColMd7 = Md | Col7,
    ColMd8 = Md | Col8,
    ColMd9 = Md | Col9,
    ColMd10 = Md | Col10,
    ColMd11 = Md | Col11,
    ColMd12 = Md | Col12,
    ColMdAuto = Md | ColAuto,

    ColLg1 = Lg | Col1,
    ColLg2 = Lg | Col2,
    ColLg3 = Lg | Col3,
    ColLg4 = Lg | Col4,
    ColLg5 = Lg | Col5,
    ColLg6 = Lg | Col6,
    ColLg7 = Lg | Col7,
    ColLg8 = Lg | Col8,
    ColLg9 = Lg | Col9,
    ColLg10 = Lg | Col10,
    ColLg11 = Lg | Col11,
    ColLg12 = Lg | Col12,
    ColLgAuto = Lg | ColAuto,

    ColXl1 = Xl | Col1,
    ColXl2 = Xl | Col2,
    ColXl3 = Xl | Col3,
    ColXl4 = Xl | Col4,
    ColXl5 = Xl | Col5,
    ColXl6 = Xl | Col6,
    ColXl7 = Xl | Col7,
    ColXl8 = Xl | Col8,
    ColXl9 = Xl | Col9,
    ColXl10 = Xl | Col10,
    ColXl11 = Xl | Col11,
    ColXl12 = Xl | Col12,
    ColXlAuto = Xl | ColAuto,

    ColXxl1 = Xxl | Col1,
    ColXxl2 = Xxl | Col2,
    ColXxl3 = Xxl | Col3,
    ColXxl4 = Xxl | Col4,
    ColXxl5 = Xxl | Col5,
    ColXxl6 = Xxl | Col6,
    ColXxl7 = Xxl | Col7,
    ColXxl8 = Xxl | Col8,
    ColXxl9 = Xxl | Col9,
    ColXxl10 = Xxl | Col10,
    ColXxl11 = Xxl | Col11,
    ColXxl12 = Xxl | Col12,
    ColXxlAuto = Xxl | ColAuto,
}

public static class ColumnOptsExtensions
{
    public static string ToBootstrapColClass(this ColumnOptions breakpoint)
    {
        var classString = "col";
        classString += breakpoint.SizeClass();
        classString += breakpoint.ColumnWidth();
        return classString;
    }

    public static string ToBootstrapOffsetClass(this ColumnOptions breakpoint)
    {
        var classString = "";
        if(breakpoint == ColumnOptions.Default) return classString;

        classString = "offset";
        classString += breakpoint.SizeClass();
        classString += breakpoint.ColumnWidth();
        return classString;
    }

    private static string SizeClass(this ColumnOptions breakpoint)
    {
        if (breakpoint.HasFlag(ColumnOptions.Sm))
        {
            return "-sm";
        }

        if (breakpoint.HasFlag(ColumnOptions.Md))
        {
            return "-md";
        }

        if (breakpoint.HasFlag(ColumnOptions.Lg))
        {
            return "-lg";
        }

        if (breakpoint.HasFlag(ColumnOptions.Xl))
        {
            return "-xl";
        }

        if (breakpoint.HasFlag(ColumnOptions.Xxl))
        {
            return "-xxl";
        }

        return "";
    }

    private static string ColumnWidth(this ColumnOptions breakpoint)
    {
        if (breakpoint.HasFlag(ColumnOptions.Col1))
        {
            return "-1";
        }

        if (breakpoint.HasFlag(ColumnOptions.Col2))
        {
            return "-2";
        }

        if (breakpoint.HasFlag(ColumnOptions.Col3))
        {
            return "-3";
        }

        if (breakpoint.HasFlag(ColumnOptions.Col4))
        {
            return "-4";
        }

        if (breakpoint.HasFlag(ColumnOptions.Col5))
        {
            return "-5";
        }

        if (breakpoint.HasFlag(ColumnOptions.Col6))
        {
            return "-6";
        }

        if (breakpoint.HasFlag(ColumnOptions.Col7))
        {
            return "-7";
        }

        if (breakpoint.HasFlag(ColumnOptions.Col8))
        {
            return "-8";
        }

        if (breakpoint.HasFlag(ColumnOptions.Col9))
        {
            return "-9";
        }

        if (breakpoint.HasFlag(ColumnOptions.Col10))
        {
            return "-10";
        }

        if (breakpoint.HasFlag(ColumnOptions.Col11))
        {
            return "-11";
        }

        if (breakpoint.HasFlag(ColumnOptions.Col12))
        {
            return "-12";
        }

        if (breakpoint.HasFlag(ColumnOptions.ColAuto))
        {
            return "-auto";
        }

        return "";
    }
}