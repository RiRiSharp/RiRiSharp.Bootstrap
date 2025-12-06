using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.BaseComponents;
using RiRiSharp.Bootstrap.Components.Carousel.Internals;

namespace RiRiSharp.Bootstrap.Components.Carousel;

public partial class BsCarousel : BsChildContentComponent
{
    protected override string BsComponentClasses => $"carousel slide {TransitionTypeClass}";

    public IBsCarouselContext? CarouselContext { get; private set; }

    [Parameter]
    public BsCarouselAutoPlayMode AutoPlay { get; set; }

    [Parameter]
    public BsCarouselTransitionType TransitionType { get; set; }

    [Parameter]
    public bool EnableTouch { get; set; } = true;

    [Inject]
    private IBsCarouselJsFunctions CarouselJsFunctions { get; set; } = null!;

    private string TransitionTypeClass => TransitionType.ToBootstrapClass();

    protected override void OnInitialized()
    {
        base.OnInitialized();
        CarouselContext = new BsCarouselContext(this);
    }

    protected override async Task OnParametersSetAsync()
    {
        await base.OnParametersSetAsync();
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

    public async Task CycleAsync()
    {
        await CarouselJsFunctions.Cycle(HtmlRef);
    }

    public async Task PauseAsync()
    {
        await CarouselJsFunctions.Pause(HtmlRef);
    }
}
