namespace Wader.Components.Carousel;

public enum BsCarouselTransitionType
{
    Slide = 0,
    Crossfade = 1,
}

public static class BsCarouselTransitionTypeExtensions
{
    public static string ToBootstrapClass(this BsCarouselTransitionType transitionType)
    {
        return transitionType switch
        {
            BsCarouselTransitionType.Slide => "",
            BsCarouselTransitionType.Crossfade => "carousel-fade",
            _ => throw new ArgumentOutOfRangeException(nameof(transitionType), transitionType, null),
        };
    }
}
