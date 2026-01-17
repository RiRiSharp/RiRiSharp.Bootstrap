using Microsoft.AspNetCore.Components;
using Wader.BaseComponents;

namespace Wader.Components.Dropdown;

public partial class BsDropdownHeader : BsChildContentComponent
{
    protected override string BsComponentClasses => "dropdown-header";

    [Parameter]
    public int Heading { get; set; } = 6;
}
