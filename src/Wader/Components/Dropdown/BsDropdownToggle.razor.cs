using Microsoft.AspNetCore.Components;
using Wader.BaseComponents;
using Wader.Components.Buttons;

namespace Wader.Components.Dropdown;

public partial class BsDropdownToggle : BsChildContentComponent
{
    protected override string BsComponentClasses => $"dropdown-toggle {ModeClass}";

    [CascadingParameter]
    public BsDropdownMode? Mode { get; set; }

    private string ModeClass => Mode?.ToBootstrapButtonClass() ?? "";

    [Parameter]
    public BsButtonSize Size { get; set; }

    [Parameter]
    public BsButtonVariant Variant { get; set; } = BsButtonVariant.Primary;
}
