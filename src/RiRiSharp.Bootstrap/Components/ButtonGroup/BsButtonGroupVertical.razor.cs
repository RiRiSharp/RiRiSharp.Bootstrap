using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.BaseComponents;

namespace RiRiSharp.Bootstrap.Components.ButtonGroup;

public partial class BsButtonGroupVertical : BsChildContentComponent
{
    protected override string BsComponentClasses => $"btn-group-vertical {Size.ToBootstrapClass()}";

    [Parameter]
    public BsButtonGroupSize Size { get; set; }
}
