using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.BaseComponents;

namespace RiRiSharp.Bootstrap.Components.Dropdown;

public partial class BsDropdown : BsChildContentComponent
{
    protected override string BsComponentClasses => $"{DropdownDirectionClass} {DropdownClass}";

    [Parameter]
    public BsDropDirection Drop { get; set; }

    private string DropdownDirectionClass => Drop.ToBootstrapClass();

    [Parameter]
    public BsDropdownMode Mode { get; set; }

    private string DropdownClass => Mode.ToBootstrapDropdownClass();
}
