namespace RiRiSharp.Bootstrap.Components.Carousel.Internals;

internal class BsCarouselContext(BsCarousel carousel) : IBsCarouselContext
{
    private readonly BsCarousel _carousel = carousel;

    public async Task MoveToSlideAsync(int n)
    {
        await _carousel.MoveToSlideAsync(n);
    }

    public async Task MovePrevAsync()
    {
        await _carousel.MovePrevAsync();
    }

    public async Task MoveNextAsync()
    {
        await _carousel.MoveNextAsync();
    }
}

public interface IBsCarouselContext
{
    Task MoveToSlideAsync(int n);
    Task MovePrevAsync();
    Task MoveNextAsync();
}
