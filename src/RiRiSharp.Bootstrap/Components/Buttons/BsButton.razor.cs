using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.BaseComponents;

namespace RiRiSharp.Bootstrap.Components.Buttons;

public partial class BsButton : BsChildContentComponent
{
    protected override string BsComponentClasses => $"btn {Variant.ToBootstrapClass()} {Size.ToBootstrapClass()}";

    [Parameter]
    public BsButtonVariant Variant { get; set; } = BsButtonVariant.Primary;

    [Parameter]
    public BsButtonSize Size { get; set; }
}
