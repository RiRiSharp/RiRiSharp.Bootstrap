namespace Wader.Components.ListGroup;

public enum BsListGroupDirection
{
    Vertical = 0,
    Horizontal = 1,
}

public static class BsListGroupDirectionExtensions
{
    public static string ToBootstrapClass(this BsListGroupDirection direction)
    {
        return direction switch
        {
            BsListGroupDirection.Vertical => "",
            BsListGroupDirection.Horizontal => "list-group-horizontal",
            _ => throw new ArgumentOutOfRangeException(nameof(direction), direction, null),
        };
    }
}
