using RiRiSharp.Bootstrap.Internals.Exceptions;
using System.Text;

namespace RiRiSharp.Bootstrap.Content.Tables;

[Flags]
public enum TableOptions : long
{
    Default = 0,

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
    private static readonly Dictionary<TableOptions, string> ClassMapping = new()
    {
        { TableOptions.TablePrimary, "table-primary" },
        { TableOptions.TableSecondary, "table-secondary" },
        { TableOptions.TableSuccess, "table-success" },
        { TableOptions.TableDanger, "table-danger" },
        { TableOptions.TableWarning, "table-warning" },
        { TableOptions.TableInfo, "table-info" },
        { TableOptions.TableLight, "table-light" },
        { TableOptions.TableDark, "table-dark" },
        { TableOptions.TableStriped, "table-striped" },
        { TableOptions.TableStripedColumns, "table-striped-columns" },
        { TableOptions.TableHover, "table-hover" },
        { TableOptions.TableBordered, "table-bordered" },
        { TableOptions.TableBorderless, "table-borderless" },
        { TableOptions.BorderPrimary, "border-primary" },
        { TableOptions.BorderSecondary, "border-secondary" },
        { TableOptions.BorderSuccess, "border-success" },
        { TableOptions.BorderDanger, "border-danger" },
        { TableOptions.BorderWarning, "border-warning" },
        { TableOptions.BorderInfo, "border-info" },
        { TableOptions.BorderLight, "border-light" },
        { TableOptions.BorderDark, "border-dark" },
        { TableOptions.TableSmall, "table-sm" },
        { TableOptions.CaptionTop, "caption-top" }
    };

    private const TableOptions _colorMask = TableOptions.TablePrimary |
                                            TableOptions.TableSecondary |
                                            TableOptions.TableSuccess |
                                            TableOptions.TableDanger |
                                            TableOptions.TableWarning |
                                            TableOptions.TableInfo |
                                            TableOptions.TableLight |
                                            TableOptions.TableDark;

    private const TableOptions _stripedMask = TableOptions.TableStriped |
                                              TableOptions.TableStripedColumns;

    private const TableOptions _tableBorderMask = TableOptions.TableBordered |
                                                  TableOptions.TableBorderless;

    private const TableOptions _borderColorMask = TableOptions.TableBorderless |
                                                  TableOptions.BorderPrimary |
                                                  TableOptions.BorderSecondary |
                                                  TableOptions.BorderSuccess |
                                                  TableOptions.BorderDanger |
                                                  TableOptions.BorderWarning |
                                                  TableOptions.BorderInfo |
                                                  TableOptions.BorderLight |
                                                  TableOptions.BorderDark;

    // For <table> everything is an allowable option, except table active
    private const TableOptions _tableMask = ~TableOptions.TableActive;

    private const TableOptions _rowMask = TableOptions.TablePrimary |
                                          TableOptions.TableSecondary |
                                          TableOptions.TableSuccess |
                                          TableOptions.TableDanger |
                                          TableOptions.TableWarning |
                                          TableOptions.TableInfo |
                                          TableOptions.TableLight |
                                          TableOptions.TableDark |
                                          TableOptions.TableActive;

    private const TableOptions _tableHeadMask = TableOptions.TablePrimary |
                                                TableOptions.TableSecondary |
                                                TableOptions.TableSuccess |
                                                TableOptions.TableDanger |
                                                TableOptions.TableWarning |
                                                TableOptions.TableInfo |
                                                TableOptions.TableLight |
                                                TableOptions.TableDark;

    public static string ToBootstrapTableClass(this TableOptions options)
    {
        var relevantTableOptions = options & _tableMask;
        relevantTableOptions.ValidateIllegalCombinations();

        return options.BuildBootstrapClassInner();
    }

    public static string ToBootstrapRowOrDataClass(this TableOptions options)
    {
        var relevantRowOptions = options & _rowMask;
        relevantRowOptions.ValidateIllegalCombinations();

        return options.BuildBootstrapClassInner();
    }

    public static string ToBootstrapTableHeadClass(this TableOptions options)
    {
        var relevantTableHeadOptions = options & _tableHeadMask;
        relevantTableHeadOptions.ValidateIllegalCombinations();

        return options.BuildBootstrapClassInner();
    }

    private static void ValidateIllegalCombinations(this TableOptions tableOptions)
    {
        var isValid = tableOptions.HasZeroOrOneBitsSetInMask(_colorMask) &&
                      tableOptions.HasZeroOrOneBitsSetInMask(_stripedMask) &&
                      tableOptions.HasZeroOrOneBitsSetInMask(_tableBorderMask) &&
                      tableOptions.HasZeroOrOneBitsSetInMask(_borderColorMask);
        if (!isValid) throw new BsInvalidTableOptionsException();
    }

    private static string BuildBootstrapClassInner(this TableOptions tableOptions)
    {
        var returnClass = new StringBuilder();

        foreach (var entry in ClassMapping)
        {
            if (tableOptions.HasFlag(entry.Key))
            {
                returnClass.Append(' ').Append(entry.Value);
            }
        }

        return returnClass.ToString();
    }

    private static bool HasZeroOrOneBitsSetInMask(this TableOptions tableOptions, TableOptions mask)
    {
        var relevantPart = tableOptions & mask;
        return relevantPart == 0 || (relevantPart & (relevantPart - 1)) == 0;
    }
}