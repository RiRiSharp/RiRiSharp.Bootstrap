using Microsoft.AspNetCore.Components;
using Wader.BaseComponents;

namespace Wader.Components.ButtonGroup;

public partial class BsButtonGroup : BsChildContentComponent
{
    protected override string BsComponentClasses => $"btn-group {Size.ToBootstrapClass()}";

    [Parameter]
    public BsButtonGroupSize Size { get; set; }
}
