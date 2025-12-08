namespace RiRiSharp.Bootstrap.Components.Collapse;

public enum BsCollapseDirection
{
    Vertical = 0,
    Horizontal = 1,
}

public static class BsCollapseDirectionExtensions
{
    public static string ToBootstrapClass(this BsCollapseDirection collapseDirection)
    {
        return collapseDirection switch
        {
            BsCollapseDirection.Vertical => "",
            BsCollapseDirection.Horizontal => "collapse-horizontal",
            _ => throw new ArgumentOutOfRangeException(nameof(collapseDirection), collapseDirection, null),
        };
    }
}
