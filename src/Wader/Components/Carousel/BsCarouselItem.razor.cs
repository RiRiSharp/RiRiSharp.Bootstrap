using Microsoft.AspNetCore.Components;
using Wader.BaseComponents;

namespace Wader.Components.Carousel;

public sealed partial class BsCarouselItem : BsChildContentComponent
{
    protected override string BsComponentClasses => $"carousel-item {ActiveClass}";

    [Parameter]
    public bool Active { get; set; }

    private string? ActiveClass => Active ? "active" : null;

    [Parameter]
    public int? Interval { get; set; }
}
