using Microsoft.AspNetCore.Components;
using Wader.BaseComponents;

namespace Wader.Components.Badge;

public partial class BsBadge : BsChildContentComponent
{
    protected override string BsComponentClasses => $"badge {PillShapeClass} {Background.ToBootstrapClass()}";

    [Parameter]
    public bool PillShape { get; set; }
    private string? PillShapeClass => PillShape ? "rounded-pill" : null;

    [Parameter]
    public BsBadgeColor Background { get; set; } = BsBadgeColor.Secondary;
}
