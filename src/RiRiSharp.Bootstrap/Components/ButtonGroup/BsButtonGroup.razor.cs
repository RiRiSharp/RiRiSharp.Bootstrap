using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.BaseComponents;

namespace RiRiSharp.Bootstrap.Components.ButtonGroup;

public partial class BsButtonGroup : BsChildContentComponent
{
    protected override string BsComponentClasses => $"btn-group {Size.ToBootstrapClass()}";

    [Parameter]
    public BsButtonGroupSize Size { get; set; }
}
