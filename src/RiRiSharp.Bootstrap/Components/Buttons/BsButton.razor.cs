using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.BaseComponents;

namespace RiRiSharp.Bootstrap.Components.Buttons;

public partial class BsButton : BsChildContentComponent
{
    [Parameter]
    public BsButtonVariant Variant { get; set; }

    [Parameter]
    public BsButtonSize Size { get; set; }
}
