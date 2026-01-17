using Microsoft.AspNetCore.Components;
using Wader.BaseComponents;

namespace Wader.Components.NavBar;

public partial class BsNavItem : BsChildContentComponent
{
    protected override string BsComponentClasses => $"nav-item {OptionsClass}";

    [Parameter]
    public BsDropdownOptions DropdownOptions { get; set; }

    private string OptionsClass => DropdownOptions.ToNavItemBootstrapClass();
}
