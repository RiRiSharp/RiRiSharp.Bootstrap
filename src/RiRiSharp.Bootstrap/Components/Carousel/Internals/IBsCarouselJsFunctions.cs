using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.Internals;

namespace RiRiSharp.Bootstrap.Components.Carousel.Internals;

public interface IBsCarouselJsFunctions : IBsJsDisposable
{
    Task MoveToSlideAsync(ElementReference carouselRef, int slideNumber);
    Task MovePrevAsync(ElementReference carouselRef);
    Task MoveNextAsync(ElementReference carouselRef);
    Task CycleAsync(ElementReference carouselRef);
    Task PauseAsync(ElementReference carouselRef);
    Task AddCycleCallbackAsync(ElementReference carouselRef);
    Task RemoveCycleCallback(ElementReference carouselRef);
}
