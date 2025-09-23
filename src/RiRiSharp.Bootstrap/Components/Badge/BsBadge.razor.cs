using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.BaseComponents;

namespace RiRiSharp.Bootstrap.Components.Badge;

public partial class BsBadge : BsChildContentComponent
{
    protected override string BsComponentClasses => $"badge {PillShapeClass} {Background.ToBootstrapClass()}";

    [Parameter]
    public bool PillShape { get; set; }
    private string PillShapeClass => PillShape ? "rounded-pill" : "";

    [Parameter]
    public BsBadgeColor Background { get; set; } = BsBadgeColor.Secondary;
}
