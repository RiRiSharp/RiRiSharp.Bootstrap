using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.BaseComponents;
using RiRiSharp.Bootstrap.Components.Buttons;

namespace RiRiSharp.Bootstrap.Components.Dropdown;

public partial class BsDropdownToggle : BsChildContentComponent
{
    protected override string BsComponentClasses => $"dropdown-toggle {ModeClass}";

    [CascadingParameter]
    public BsDropdownMode Mode { get; set; }

    private string ModeClass => Mode.ToBootstrapButtonClass();

    [Inject]
    [Parameter]
    public BsButtonSize Size { get; set; }

    [Parameter]
    public BsButtonVariant Variant { get; set; } = BsButtonVariant.Primary;
}
