using Microsoft.AspNetCore.Components;
using Wader.BaseComponents;
using Wader.Primitives;

namespace Wader.Components.Dropdown;

public partial class BsDropdownMenu : BsChildContentComponent
{
    protected override string BsComponentClasses => $"dropdown-menu {DirectionClass}";

    // TODO: Add option to add breakpoints
    [Parameter]
    public BsDirection Direction { get; set; } = BsDirection.Start;

    private string DirectionClass => Direction.ToDropdownBootstrapClass();
}
