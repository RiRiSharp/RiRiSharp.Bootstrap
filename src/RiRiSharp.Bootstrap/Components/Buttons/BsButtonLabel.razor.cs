using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.BaseComponents;

namespace RiRiSharp.Bootstrap.Components.Buttons;

/// <summary>
/// Renders a label as a Bootstrap button
/// </summary>
/// <remarks>
/// Technically, this class should be located inside ButtonGroup, but that would break consistency a lot
/// </remarks>
public partial class BsButtonLabel : BsChildContentComponent
{
    [Parameter]
    public BsButtonVariant Variant { get; set; } = BsButtonVariant.Primary;

    [Parameter]
    public BsButtonSize Size { get; set; }
}
