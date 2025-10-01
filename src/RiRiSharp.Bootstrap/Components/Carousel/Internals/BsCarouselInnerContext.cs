namespace RiRiSharp.Bootstrap.Components.Carousel.Internals;

internal class BsCarouselInnerContext : IBsCarouselInnerContext
{
    private readonly HashSet<BsCarouselItem> _items = [];

    public void Register(BsCarouselItem carouselItem)
    {
        _ = _items.Add(carouselItem);
    }

    public void Deregister(BsCarouselItem carouselItem)
    {
        _ = _items.Remove(carouselItem);
    }

    internal void Verify()
    {
        var activeCount = _items.Count(i => i.IsActive);
        if (activeCount != 1)
        {
            throw new BsCarouselException(
                "More than one carousel item is registered as active, where only 1 is allowed."
            );
        }
    }
}

public interface IBsCarouselInnerContext
{
    void Register(BsCarouselItem carouselItem);
    void Deregister(BsCarouselItem carouselItem);
}
