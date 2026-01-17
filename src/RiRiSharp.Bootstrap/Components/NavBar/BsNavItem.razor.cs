using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.BaseComponents;

namespace RiRiSharp.Bootstrap.Components.NavBar;

public partial class BsNavItem : BsChildContentComponent
{
    protected override string BsComponentClasses => $"nav-item {OptionsClass}";

    [Parameter]
    public BsDropdownOptions DropdownOptions { get; set; }

    private string OptionsClass => DropdownOptions.ToNavItemBootstrapClass();
}
