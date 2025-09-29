using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.BaseComponents;

namespace RiRiSharp.Bootstrap.Content.Images;

public partial class BsImage : BsComponent
{
    protected override string BsComponentClasses => Options.ToBootstrapClass();

    [Parameter]
    public BsImageOptions Options { get; set; }

    [Parameter, EditorRequired]
    public string Src { get; set; }

    [Parameter]
    public string? Alt { get; set; }
}
