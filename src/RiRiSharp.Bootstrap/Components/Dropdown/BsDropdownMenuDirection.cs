namespace RiRiSharp.Bootstrap.Components.Dropdown;

public enum BsDropdownMenuDirection
{
    Start = 0,
    End = 1,
}

public static class BsDropdownMenuDirectionExtensions
{
    public static string ToBootstrapClass(this BsDropdownMenuDirection direction)
    {
        return direction switch
        {
            BsDropdownMenuDirection.Start => "",
            BsDropdownMenuDirection.End => "dropdown-menu-end",
            _ => throw new ArgumentOutOfRangeException(nameof(direction), direction, null),
        };
    }
}
