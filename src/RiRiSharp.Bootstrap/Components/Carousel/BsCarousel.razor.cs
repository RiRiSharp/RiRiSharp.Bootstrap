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

    private BsCarouselAutoPlayMode? _lastAutoPlay;
    private bool _autoPlayChanged;

    protected override void OnParametersSet()
    {
        base.OnParametersSet();
        if (_lastAutoPlay == AutoPlay)
        {
            return;
        }

        _autoPlayChanged = true;
        _lastAutoPlay = AutoPlay;
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await base.OnAfterRenderAsync(firstRender);
        if (!_autoPlayChanged)
        {
            return;
        }

        await RemoveCycleCallback();
        if (AutoPlay is BsCarouselAutoPlayMode.AutoPlayAfterUserInteraction)
        {
            await AddCycleCallback();
        }

        if (AutoPlay is BsCarouselAutoPlayMode.AutoPlay)
        {
            await CycleAsync();
        }

        _autoPlayChanged = false;
    }

    public async Task MoveToSlideAsync(int i)
    {
        await CarouselJsFunctions.MoveToSlideAsync(HtmlRef, i);
        if (AutoPlay is BsCarouselAutoPlayMode.AutoPlayAfterUserInteraction)
        {
            await AddCycleCallback();
        }
    }

    public async Task MovePrevAsync()
    {
        await CarouselJsFunctions.MovePrevAsync(HtmlRef);
        if (AutoPlay is BsCarouselAutoPlayMode.AutoPlayAfterUserInteraction)
        {
            await AddCycleCallback();
        }
    }

    public async Task MoveNextAsync()
    {
        await CarouselJsFunctions.MoveNextAsync(HtmlRef);
        if (AutoPlay is BsCarouselAutoPlayMode.AutoPlayAfterUserInteraction)
        {
            await AddCycleCallback();
        }
    }

    public async Task CycleAsync()
    {
        await CarouselJsFunctions.Cycle(HtmlRef);
    }

    public async Task PauseAsync()
    {
        await CarouselJsFunctions.Pause(HtmlRef);
        if (AutoPlay is BsCarouselAutoPlayMode.AutoPlayAfterUserInteraction)
        {
            await RemoveCycleCallback();
        }
    }

    private async Task AddCycleCallback()
    {
        await CarouselJsFunctions.AddCycleCallback(HtmlRef);
    }

    private async Task RemoveCycleCallback()
    {
        await CarouselJsFunctions.RemoveCycleCallback(HtmlRef);
    }
}
