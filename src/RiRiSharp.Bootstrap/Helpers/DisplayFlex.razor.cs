using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.BaseComponents;

namespace RiRiSharp.Bootstrap.Helpers;

public partial class DisplayFlex : BsChildContentComponent
{
    protected override string BsComponentClasses => $"d-flex {Justify.ToBootstrapClass()}";

    [Parameter]
    public BsJustification Justify { get; set; }
}
