using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.BaseComponents;

namespace RiRiSharp.Bootstrap.Components.Buttons;

public partial class BsButtonInput : BsComponent
{
    [Parameter]
    public string? Content { get; set; }

    [Parameter]
    public BsButtonVariant Variant { get; set; } = BsButtonVariant.Primary;

    [Parameter]
    public BsButtonSize Size { get; set; }
}
