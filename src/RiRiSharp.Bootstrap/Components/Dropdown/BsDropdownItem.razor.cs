using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.BaseComponents;

namespace RiRiSharp.Bootstrap.Components.Dropdown;

public partial class BsDropdownItem : BsChildContentComponent
{
    protected override string BsComponentClasses => $"dropdown-item {ActiveClass} {DisabledClass}";

    [Parameter]
    public bool Active { get; set; }

    private string ActiveClass => Active ? "active" : "";

    [Parameter]
    public bool Disabled { get; set; }

    private string DisabledClass => Disabled ? "disabled" : "";
}
