namespace Wader.Components.NavBar;

public enum BsDropdownOptions
{
    NoDropdown = 0,
    WithDropdown = 1,
}

public static class DropdownOptionsExtensions
{
    public static string ToNavItemBootstrapClass(this BsDropdownOptions options)
    {
        return options switch
        {
            BsDropdownOptions.NoDropdown => "",
            BsDropdownOptions.WithDropdown => "dropdown",
            _ => throw new ArgumentOutOfRangeException(nameof(options), options, null),
        };
    }

    public static string ToNavLinkBootstrapClass(this BsDropdownOptions options)
    {
        return options switch
        {
            BsDropdownOptions.NoDropdown => "",
            BsDropdownOptions.WithDropdown => "dropdown-toggle",
            _ => throw new ArgumentOutOfRangeException(nameof(options), options, null),
        };
    }
}
