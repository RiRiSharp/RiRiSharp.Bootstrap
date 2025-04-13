namespace RiRiSharp.Bootstrap.Core.Layout.GridColumns;

[Flags]
public enum GridColumnOptions : long
{
    Default = 0,
    Sm = 1 << 1,
    Md = 1 << 2,
    Lg = 1 << 3,
    Xl = 1 << 4,
    Xxl = 1 << 5,

    GCol1 = 1 << 6,
    GCol2 = 1 << 7,
    GCol3 = 1 << 8,
    GCol4 = 1 << 9,
    GCol5 = 1 << 10,
    GCol6 = 1 << 11,
    GCol7 = 1 << 12,
    GCol8 = 1 << 13,
    GCol9 = 1 << 14,
    GCol10 = 1 << 15,
    GCol11 = 1 << 16,
    GCol12 = 1 << 17,
    GColAuto = 1 << 18,

    GColSm1 = Sm | GCol1,
    GColSm2 = Sm | GCol2,
    GColSm3 = Sm | GCol3,
    GColSm4 = Sm | GCol4,
    GColSm5 = Sm | GCol5,
    GColSm6 = Sm | GCol6,
    GColSm7 = Sm | GCol7,
    GColSm8 = Sm | GCol8,
    GColSm9 = Sm | GCol9,
    GColSm10 = Sm | GCol10,
    GColSm11 = Sm | GCol11,
    GColSm12 = Sm | GCol12,
    GColSmAuto = Sm | GColAuto,

    GColMd1 = Md | GCol1,
    GColMd2 = Md | GCol2,
    GColMd3 = Md | GCol3,
    GColMd4 = Md | GCol4,
    GColMd5 = Md | GCol5,
    GColMd6 = Md | GCol6,
    GColMd7 = Md | GCol7,
    GColMd8 = Md | GCol8,
    GColMd9 = Md | GCol9,
    GColMd10 = Md | GCol10,
    GColMd11 = Md | GCol11,
    GColMd12 = Md | GCol12,
    GColMdAuto = Md | GColAuto,

    GColLg1 = Lg | GCol1,
    GColLg2 = Lg | GCol2,
    GColLg3 = Lg | GCol3,
    GColLg4 = Lg | GCol4,
    GColLg5 = Lg | GCol5,
    GColLg6 = Lg | GCol6,
    GColLg7 = Lg | GCol7,
    GColLg8 = Lg | GCol8,
    GColLg9 = Lg | GCol9,
    GColLg10 = Lg | GCol10,
    GColLg11 = Lg | GCol11,
    GColLg12 = Lg | GCol12,
    GColLgAuto = Lg | GColAuto,

    GColXl1 = Xl | GCol1,
    GColXl2 = Xl | GCol2,
    GColXl3 = Xl | GCol3,
    GColXl4 = Xl | GCol4,
    GColXl5 = Xl | GCol5,
    GColXl6 = Xl | GCol6,
    GColXl7 = Xl | GCol7,
    GColXl8 = Xl | GCol8,
    GColXl9 = Xl | GCol9,
    GColXl10 = Xl | GCol10,
    GColXl11 = Xl | GCol11,
    GColXl12 = Xl | GCol12,
    GColXlAuto = Xl | GColAuto,

    GColXxl1 = Xxl | GCol1,
    GColXxl2 = Xxl | GCol2,
    GColXxl3 = Xxl | GCol3,
    GColXxl4 = Xxl | GCol4,
    GColXxl5 = Xxl | GCol5,
    GColXxl6 = Xxl | GCol6,
    GColXxl7 = Xxl | GCol7,
    GColXxl8 = Xxl | GCol8,
    GColXxl9 = Xxl | GCol9,
    GColXxl10 = Xxl | GCol10,
    GColXxl11 = Xxl | GCol11,
    GColXxl12 = Xxl | GCol12,
    GColXxlAuto = Xxl | GColAuto,
}

public static class GridColumnOptionsExtensions
{
    public static string ToBootstrapClass(this GridColumnOptions gridColumnOptions)
    {
        if (gridColumnOptions == GridColumnOptions.Default)
        {
            return string.Empty;
        }
        
        var classString = "g-col";
        classString += gridColumnOptions.SizeClass();
        classString += gridColumnOptions.ColumnWidth();
        return classString;
    }

    private static string SizeClass(this GridColumnOptions gridColumnOptions)
    {
        if (gridColumnOptions.HasFlag(GridColumnOptions.Sm))
        {
            return "-sm";
        }

        if (gridColumnOptions.HasFlag(GridColumnOptions.Md))
        {
            return "-md";
        }

        if (gridColumnOptions.HasFlag(GridColumnOptions.Lg))
        {
            return "-lg";
        }

        if (gridColumnOptions.HasFlag(GridColumnOptions.Xl))
        {
            return "-xl";
        }

        if (gridColumnOptions.HasFlag(GridColumnOptions.Xxl))
        {
            return "-xxl";
        }

        return string.Empty;
    }

    private static string ColumnWidth(this GridColumnOptions gridColumnOptions)
    {
        if (gridColumnOptions.HasFlag(GridColumnOptions.GCol1))
        {
            return "-1";
        }

        if (gridColumnOptions.HasFlag(GridColumnOptions.GCol2))
        {
            return "-2";
        }

        if (gridColumnOptions.HasFlag(GridColumnOptions.GCol3))
        {
            return "-3";
        }

        if (gridColumnOptions.HasFlag(GridColumnOptions.GCol4))
        {
            return "-4";
        }

        if (gridColumnOptions.HasFlag(GridColumnOptions.GCol5))
        {
            return "-5";
        }

        if (gridColumnOptions.HasFlag(GridColumnOptions.GCol6))
        {
            return "-6";
        }

        if (gridColumnOptions.HasFlag(GridColumnOptions.GCol7))
        {
            return "-7";
        }

        if (gridColumnOptions.HasFlag(GridColumnOptions.GCol8))
        {
            return "-8";
        }

        if (gridColumnOptions.HasFlag(GridColumnOptions.GCol9))
        {
            return "-9";
        }

        if (gridColumnOptions.HasFlag(GridColumnOptions.GCol10))
        {
            return "-10";
        }

        if (gridColumnOptions.HasFlag(GridColumnOptions.GCol11))
        {
            return "-11";
        }

        if (gridColumnOptions.HasFlag(GridColumnOptions.GCol12))
        {
            return "-12";
        }

        if (gridColumnOptions.HasFlag(GridColumnOptions.GColAuto))
        {
            return "-auto";
        }

        return string.Empty;
    }
}