using Microsoft.AspNetCore.Components;

namespace RiRiSharp.Bootstrap.Components.Carousel.Internals;

public interface IBsCarouselJsFunctions
{
    Task MoveToSlideAsync(ElementReference carouselRef, int slideNumber);
    Task MovePrevAsync(ElementReference carouselRef);
    Task MoveNextAsync(ElementReference carouselRef);
    Task Cycle(ElementReference carouselRef);
    Task Pause(ElementReference carouselRef);
}
