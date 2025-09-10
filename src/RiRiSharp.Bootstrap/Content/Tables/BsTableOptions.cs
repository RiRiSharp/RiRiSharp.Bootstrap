using System.Text;
using RiRiSharp.Bootstrap.Internals.Exceptions;

namespace RiRiSharp.Bootstrap.Content.Tables;

[Flags]
public enum BsTableOptions : long
{
    None = 0,

    TablePrimary = 1 << 0,
    TableSecondary = 1 << 1,
    TableSuccess = 1 << 2,
    TableDanger = 1 << 3,
    TableWarning = 1 << 4,
    TableInfo = 1 << 5,
    TableLight = 1 << 6,
    TableDark = 1 << 7,

    TableStriped = 1 << 8,
    TableStripedColumns = 1 << 9,

    TableHover = 1 << 10,

    TableBordered = 1 << 11,

    TableBorderless = 1 << 12,
    BorderPrimary = 1 << 13,
    BorderSecondary = 1 << 14,
    BorderSuccess = 1 << 15,
    BorderDanger = 1 << 16,
    BorderWarning = 1 << 17,
    BorderInfo = 1 << 18,
    BorderLight = 1 << 19,
    BorderDark = 1 << 20,

    TableSmall = 1 << 21,

    CaptionTop = 1 << 22,

    TableActive = 1 << 23,
}

public static class TableOptionsExtensions
{
    private static readonly Dictionary<BsTableOptions, string> _classMapping = new()
    {
        { BsTableOptions.TablePrimary, "table-primary" },
        { BsTableOptions.TableSecondary, "table-secondary" },
        { BsTableOptions.TableSuccess, "table-success" },
        { BsTableOptions.TableDanger, "table-danger" },
        { BsTableOptions.TableWarning, "table-warning" },
        { BsTableOptions.TableInfo, "table-info" },
        { BsTableOptions.TableLight, "table-light" },
        { BsTableOptions.TableDark, "table-dark" },
        { BsTableOptions.TableStriped, "table-striped" },
        { BsTableOptions.TableStripedColumns, "table-striped-columns" },
        { BsTableOptions.TableHover, "table-hover" },
        { BsTableOptions.TableBordered, "table-bordered" },
        { BsTableOptions.TableBorderless, "table-borderless" },
        { BsTableOptions.BorderPrimary, "border-primary" },
        { BsTableOptions.BorderSecondary, "border-secondary" },
        { BsTableOptions.BorderSuccess, "border-success" },
        { BsTableOptions.BorderDanger, "border-danger" },
        { BsTableOptions.BorderWarning, "border-warning" },
        { BsTableOptions.BorderInfo, "border-info" },
        { BsTableOptions.BorderLight, "border-light" },
        { BsTableOptions.BorderDark, "border-dark" },
        { BsTableOptions.TableSmall, "table-sm" },
        { BsTableOptions.CaptionTop, "caption-top" },
    };

    private const BsTableOptions _colorMask =
        BsTableOptions.TablePrimary
        | BsTableOptions.TableSecondary
        | BsTableOptions.TableSuccess
        | BsTableOptions.TableDanger
        | BsTableOptions.TableWarning
        | BsTableOptions.TableInfo
        | BsTableOptions.TableLight
        | BsTableOptions.TableDark;

    private const BsTableOptions _stripedMask = BsTableOptions.TableStriped | BsTableOptions.TableStripedColumns;

    private const BsTableOptions _tableBorderMask = BsTableOptions.TableBordered | BsTableOptions.TableBorderless;

    private const BsTableOptions _borderColorMask =
        BsTableOptions.TableBorderless
        | BsTableOptions.BorderPrimary
        | BsTableOptions.BorderSecondary
        | BsTableOptions.BorderSuccess
        | BsTableOptions.BorderDanger
        | BsTableOptions.BorderWarning
        | BsTableOptions.BorderInfo
        | BsTableOptions.BorderLight
        | BsTableOptions.BorderDark;

    /// <summary>
    /// For table everything is an allowable option, except table active
    /// </summary>
    private const BsTableOptions _tableMask = ~BsTableOptions.TableActive;

    private const BsTableOptions _rowMask =
        BsTableOptions.TablePrimary
        | BsTableOptions.TableSecondary
        | BsTableOptions.TableSuccess
        | BsTableOptions.TableDanger
        | BsTableOptions.TableWarning
        | BsTableOptions.TableInfo
        | BsTableOptions.TableLight
        | BsTableOptions.TableDark
        | BsTableOptions.TableActive;

    private const BsTableOptions _tableHeadMask =
        BsTableOptions.TablePrimary
        | BsTableOptions.TableSecondary
        | BsTableOptions.TableSuccess
        | BsTableOptions.TableDanger
        | BsTableOptions.TableWarning
        | BsTableOptions.TableInfo
        | BsTableOptions.TableLight
        | BsTableOptions.TableDark;

    public static string ToBootstrapTableClass(this BsTableOptions options)
    {
        var relevantTableOptions = options & _tableMask;
        relevantTableOptions.ValidateIllegalCombinations();

        return options.BuildBootstrapClassInner();
    }

    public static string ToBootstrapRowOrDataClass(this BsTableOptions options)
    {
        var relevantRowOptions = options & _rowMask;
        relevantRowOptions.ValidateIllegalCombinations();

        return options.BuildBootstrapClassInner();
    }

    public static string ToBootstrapTableHeadClass(this BsTableOptions options)
    {
        var relevantTableHeadOptions = options & _tableHeadMask;
        relevantTableHeadOptions.ValidateIllegalCombinations();

        return options.BuildBootstrapClassInner();
    }

    private static void ValidateIllegalCombinations(this BsTableOptions tableOptions)
    {
        var isValid =
            tableOptions.HasZeroOrOneBitsSetInMask(_colorMask)
            && tableOptions.HasZeroOrOneBitsSetInMask(_stripedMask)
            && tableOptions.HasZeroOrOneBitsSetInMask(_tableBorderMask)
            && tableOptions.HasZeroOrOneBitsSetInMask(_borderColorMask);
        if (!isValid)
        {
            throw new BsInvalidTableOptionsException();
        }
    }

    private static string BuildBootstrapClassInner(this BsTableOptions tableOptions)
    {
        var returnClass = new StringBuilder();

        foreach (var entry in _classMapping)
        {
            if (tableOptions.HasFlag(entry.Key))
            {
                _ = returnClass.Append(' ').Append(entry.Value);
            }
        }

        return returnClass.ToString();
    }

    private static bool HasZeroOrOneBitsSetInMask(this BsTableOptions tableOptions, BsTableOptions mask)
    {
        var relevantPart = tableOptions & mask;
        return relevantPart == 0 || (relevantPart & (relevantPart - 1)) == 0;
    }
}
