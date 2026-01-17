using Microsoft.AspNetCore.Components;
using Wader.BaseComponents;

namespace Wader.Helpers;

public partial class DisplayFlex : BsChildContentComponent
{
    protected override string BsComponentClasses => $"d-flex {Justify.ToBootstrapClass()}";

    [Parameter]
    public BsJustification Justify { get; set; }
}
