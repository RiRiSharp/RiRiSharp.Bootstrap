using Microsoft.AspNetCore.Components;
using Wader.BaseComponents;

namespace Wader.Components.NavBar;

public partial class BsNavLink : BsChildContentComponent
{
    protected override string BsComponentClasses => $"nav-link {DropdownOptionsClass}";

    [CascadingParameter]
    private BsDropdownOptions? DropdownOptions { get; set; }

    private string DropdownOptionsClass => DropdownOptions?.ToNavLinkBootstrapClass() ?? "";
}
