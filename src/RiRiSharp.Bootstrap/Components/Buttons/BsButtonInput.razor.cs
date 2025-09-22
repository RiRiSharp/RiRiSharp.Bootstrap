using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.BaseComponents;

namespace RiRiSharp.Bootstrap.Components.Buttons;

public partial class BsButtonInput : BsComponent
{
    [Parameter]
    public string? Value { get; set; }

    [Parameter]
    public BsButtonVariant Variant { get; set; }

    [Parameter]
    public BsButtonSize Size { get; set; }
}
