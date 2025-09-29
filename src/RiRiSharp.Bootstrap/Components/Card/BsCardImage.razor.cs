using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.BaseComponents;

namespace RiRiSharp.Bootstrap.Components.Card;

public partial class BsCardImage : BsChildContentComponent
{
    protected override string BsComponentClasses => Position.ToBootstrapClass();

    [Parameter]
    public BsCardImagePosition Position { get; set; }

    [Parameter, EditorRequired]
    public string Src { get; set; }

    [Parameter]
    public string? Alt { get; set; }
}
