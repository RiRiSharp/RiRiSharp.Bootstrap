namespace RiRiSharp.Bootstrap.Content.Tables;

public enum BsTableResponsiveness
{
    Default,
    Sm,
    Md,
    Lg,
    Xl,
    Xxl
}

public static class TableResponsivenessExtensions
{
    public static string ToBootstrapClass(this BsTableResponsiveness tableResponsiveness)
    {
        return tableResponsiveness switch
        {
            BsTableResponsiveness.Default => "",
            BsTableResponsiveness.Sm => "table-responsive-sm",
            BsTableResponsiveness.Md => "table-responsive-md",
            BsTableResponsiveness.Lg => "table-responsive-lg",
            BsTableResponsiveness.Xl => "table-responsive-xl",
            BsTableResponsiveness.Xxl => "table-responsive-xxl",
            _ => throw new ArgumentOutOfRangeException(nameof(tableResponsiveness), tableResponsiveness, null)
        };
    }
}