using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.BaseComponents;
using RiRiSharp.Bootstrap.Components.Carousel.Internals;

namespace RiRiSharp.Bootstrap.Components.Carousel;

public partial class BsCarousel : BsChildContentComponent
{
    protected override string BsComponentClasses => $"carousel {TransitionTypeClass}";

    public IBsCarouselContext? CarouselContext { get; private set; }

    [Parameter]
    public BsCarouselAutoPlayMode AutoPlay { get; set; }

    [Parameter]
    public BsCarouselTransitionType TransitionType { get; set; }

    [Parameter]
    public bool EnableTouch { get; set; } = true;

    [Inject]
    private IBsCarouselJsFunctions CarouselJsFunctions { get; set; } = null!;

    public string TransitionTypeClass => TransitionType.ToString().ToLowerInvariant();

    protected override void OnInitialized()
    {
        base.OnInitialized();
        CarouselContext = new BsCarouselContext(this);
    }

    public async Task MoveToSlideAsync(int i)
    {
        await CarouselJsFunctions.MoveToSlideAsync(HtmlRef, i);
    }

    public async Task MovePrevAsync()
    {
        await CarouselJsFunctions.MovePrevAsync(HtmlRef);
    }

    public async Task MoveNextAsync()
    {
        await CarouselJsFunctions.MoveNextAsync(HtmlRef);
    }
}
