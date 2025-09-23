using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.BaseComponents;

namespace RiRiSharp.Bootstrap.Components.Buttons;

public partial class BsButtonLink : BsChildContentComponent
{
    protected override string BsComponentClasses =>
        $"btn {Variant.ToBootstrapClass()} {Size.ToBootstrapClass()} {DisabledClass}";

    private string DisabledClass => Disabled ? "disabled" : "";

    [Parameter]
    public BsButtonVariant Variant { get; set; } = BsButtonVariant.Primary;

    [Parameter]
    public BsButtonSize Size { get; set; }

    [Parameter]
    public bool Disabled { get; set; }
}
