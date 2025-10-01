namespace RiRiSharp.Bootstrap.Components.Carousel.Internals;

internal class BsCarouselContext(BsCarousel carousel) : IBsCarouselContext
{
    private readonly BsCarousel _carousel = carousel;

    public Task MoveToSlideAsync(int n)
    {
        throw new NotImplementedException($"{nameof(_carousel)} has not been implemented.");
    }

    public Task MovePrevAsync()
    {
        throw new NotImplementedException();
    }

    public Task MoveNextAsync()
    {
        throw new NotImplementedException();
    }
}

public interface IBsCarouselContext
{
    Task MoveToSlideAsync(int n);
    Task MovePrevAsync();
    Task MoveNextAsync();
}
