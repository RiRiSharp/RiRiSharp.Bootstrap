namespace RiRiSharp.Bootstrap.Components.Dropdown;

public enum BsDropdownMode
{
    Regular = 0,
    Split = 1,
}

public static class BsDropdownModeExtensions
{
    public static string ToBootstrapDropdownClass(this BsDropdownMode mode)
    {
        return mode switch
        {
            BsDropdownMode.Regular => "",
            BsDropdownMode.Split => "btn-group",
            _ => throw new ArgumentOutOfRangeException(nameof(mode), mode, null),
        };
    }

    public static string ToBootstrapButtonClass(this BsDropdownMode mode)
    {
        return mode switch
        {
            BsDropdownMode.Regular => "",
            BsDropdownMode.Split => "dropdown-toggle-split",
            _ => throw new ArgumentOutOfRangeException(nameof(mode), mode, null),
        };
    }
}
