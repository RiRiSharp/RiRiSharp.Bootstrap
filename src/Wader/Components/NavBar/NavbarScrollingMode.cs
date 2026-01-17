namespace Wader.Components.NavBar;

public enum NavbarScrollingMode
{
    Regular = 0,
    EnableVerticalScrolling = 1,
}

public static class NavbarScrollingModeExtensions
{
    public static string ToBootstrapClass(this NavbarScrollingMode mode)
    {
        return mode switch
        {
            NavbarScrollingMode.Regular => "",
            NavbarScrollingMode.EnableVerticalScrolling => "navbar-nav-scroll",
            _ => throw new ArgumentOutOfRangeException(nameof(mode), mode, null),
        };
    }
}
