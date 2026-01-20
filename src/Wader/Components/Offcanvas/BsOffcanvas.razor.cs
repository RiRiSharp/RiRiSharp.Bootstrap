using Microsoft.AspNetCore.Components;
using Wader.BaseComponents;
using Wader.Shared;

namespace Wader.Components.Offcanvas;

public partial class BsOffcanvas : BsChildContentComponent
{
    protected override string BsComponentClasses => $"offcanvas {DirectionClass}";

    [Parameter]
    public BsDirection Direction { get; set; }

    private string DirectionClass => Direction.ToOffcanvasBootstrapClass();
}
