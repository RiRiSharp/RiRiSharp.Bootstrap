using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.BaseComponents;
using RiRiSharp.Bootstrap.Components.Carousel.Internals;

namespace RiRiSharp.Bootstrap.Components.Carousel;

public partial class BsCarouselIndicatorButton : BsComponent, IBsChildContentComponent
{
    protected override string BsComponentClasses => ActiveClass;

    [CascadingParameter]
    private IBsCarouselContext? CarouselContext { get; set; }

    [Parameter]
    public RenderFragment? ChildContent { get; set; }

    [Parameter]
    public bool IsActive { get; set; }

    private string ActiveClass => IsActive ? "active" : "";

    [Parameter]
    // Zero based index
    public int? SlideNo { get; set; }

    public async Task MoveToCorrespondingSlideAsync()
    {
        if (SlideNo is null or < 0)
        {
            throw new InvalidOperationException($"Slide number {SlideNo} is invalid");
        }

        await CarouselContext!.MoveToSlideAsync(SlideNo.Value);
    }
}
