using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.BaseComponents;

namespace RiRiSharp.Bootstrap.Components.Dropdown;

public partial class BsDropdownHeader : BsChildContentComponent
{
    protected override string BsComponentClasses => "dropdown-header";

    [Parameter]
    public int Heading { get; set; } = 6;
}
