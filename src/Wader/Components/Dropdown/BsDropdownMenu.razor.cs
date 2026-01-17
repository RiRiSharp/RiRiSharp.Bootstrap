using Microsoft.AspNetCore.Components;
using Wader.BaseComponents;

namespace Wader.Components.Dropdown;

public partial class BsDropdownMenu : BsChildContentComponent
{
    protected override string BsComponentClasses => $"dropdown-menu {DirectionClass}";

    // TODO: Add option to add breakpoints
    [Parameter]
    public BsDropdownMenuDirection Direction { get; set; }

    private string DirectionClass => Direction.ToBootstrapClass();
}
