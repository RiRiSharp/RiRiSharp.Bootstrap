using Microsoft.AspNetCore.Components;
using Wader.BaseComponents;

namespace Wader.Components.Offcanvas;

public partial class OffcanvasTitle : BsChildContentComponent
{
    protected override string BsComponentClasses => "offcanvas-title";

    [Parameter]
    public int Heading { get; set; } = 5;
}
