using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.BaseComponents;

namespace RiRiSharp.Bootstrap.Components.ButtonGroup;

public partial class BsButtonGroupVertical : BsChildContentComponent
{
    [Parameter]
    public BsButtonGroupSize Size { get; set; }
}
