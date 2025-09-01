namespace RiRiSharp.Bootstrap.Helpers;

public enum Justification
{
    Start,
    End,
    Center,
    Between,
    Around,
    Evenly
}

public static class JustificationExtensions
{
    public static string ToBootstrapClass(this Justification justification)
    {
        return justification switch
        {
            Justification.Start => "justify-content-start",
            Justification.End => "justify-content-end",
            Justification.Center => "justify-content-center",
            Justification.Between => "justify-content-between",
            Justification.Around => "justify-content-around",
            Justification.Evenly => "justify-content-evenly",
            _ => throw new ArgumentOutOfRangeException(nameof(justification),  justification, null)
        };
    }
}