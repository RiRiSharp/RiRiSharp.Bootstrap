namespace RiRiSharp.Bootstrap.Helpers;

public enum BsJustification
{
    Start = 0,
    End = 1,
    Center = 2,
    Between = 3,
    Around = 4,
    Evenly = 5,
}

public static class JustificationExtensions
{
    public static string ToBootstrapClass(this BsJustification justification)
    {
        return justification switch
        {
            BsJustification.Start => "justify-content-start",
            BsJustification.End => "justify-content-end",
            BsJustification.Center => "justify-content-center",
            BsJustification.Between => "justify-content-between",
            BsJustification.Around => "justify-content-around",
            BsJustification.Evenly => "justify-content-evenly",
            _ => throw new ArgumentOutOfRangeException(nameof(justification), justification, null),
        };
    }
}
