using RiRiSharp.Bootstrap.BaseComponents;

namespace RiRiSharp.Bootstrap.Components.NavBar;

public partial class BsNavbarNav : BsChildContentComponent
{
    protected override string BsComponentClasses => $"navbar-nav {ModeClass}";
    public NavbarScrollingMode Mode { get; set; }
    private string ModeClass => Mode.ToBootstrapClass();
}
