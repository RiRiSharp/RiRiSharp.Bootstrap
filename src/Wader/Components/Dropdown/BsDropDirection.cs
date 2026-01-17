namespace Wader.Components.Dropdown;

public enum BsDropDirection
{
    Down = 0,
    Up = 1,
    Start = 2,
    End = 3,
}

public static class DropdownDirectionExtensions
{
    public static string ToBootstrapClass(this BsDropDirection direction)
    {
        return direction switch
        {
            BsDropDirection.Down => "dropdown",
            BsDropDirection.Up => "dropup",
            BsDropDirection.Start => "dropstart",
            BsDropDirection.End => "dropend",
            _ => throw new ArgumentOutOfRangeException(nameof(direction), direction, null),
        };
    }
}
