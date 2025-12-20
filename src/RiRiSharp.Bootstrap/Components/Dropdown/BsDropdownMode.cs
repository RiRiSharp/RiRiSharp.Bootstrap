namespace RiRiSharp.Bootstrap.Components.Dropdown;

public enum BsDropdownMode
{
    Regular = 0,
    ToggleSplit = 1,
}

public static class BsDropdownModeExtensions
{
    public static string ToBootstrapClass(this BsDropdownMode mode)
    {
        return mode switch
        {
            BsDropdownMode.Regular => "",
            BsDropdownMode.ToggleSplit => "toggle-split",
            _ => throw new ArgumentOutOfRangeException(nameof(mode), mode, null),
        };
    }
}
