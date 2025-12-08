using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.BaseComponents;

namespace RiRiSharp.Bootstrap.Components.Carousel;

public sealed partial class BsCarouselItem : BsChildContentComponent
{
    protected override string BsComponentClasses => $"carousel-item {ActiveClass}";

    [Parameter]
    public bool IsActive { get; set; }

    private string ActiveClass => IsActive ? "active" : "";

    [Parameter]
    public int? Interval { get; set; }
}
