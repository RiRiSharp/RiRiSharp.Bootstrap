using Microsoft.AspNetCore.Components;
using Wader.BaseComponents;

namespace Wader.Components.Carousel;

public sealed partial class BsCarouselItem : BsChildContentComponent
{
    protected override string BsComponentClasses => $"carousel-item {ActiveClass}";

    [Parameter]
    public bool IsActive { get; set; }

    private string ActiveClass => IsActive ? "active" : "";

    [Parameter]
    public int? Interval { get; set; }
}
