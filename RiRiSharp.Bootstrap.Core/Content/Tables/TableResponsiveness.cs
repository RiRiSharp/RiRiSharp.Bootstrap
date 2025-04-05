namespace RiRiSharp.Bootstrap.Core.Content.Tables;

public enum TableResponsiveness
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
    public static string ToBootstrapClass(this TableResponsiveness tableResponsiveness)
    {
        return tableResponsiveness switch
        {
            TableResponsiveness.Default => "",
            TableResponsiveness.Sm => "table-responsive-sm",
            TableResponsiveness.Md => "table-responsive-md",
            TableResponsiveness.Lg => "table-responsive-lg",
            TableResponsiveness.Xl => "table-responsive-xl",
            TableResponsiveness.Xxl => "table-responsive-xxl",
            _ => throw new ArgumentOutOfRangeException(nameof(tableResponsiveness), tableResponsiveness, null)
        };
    }
}