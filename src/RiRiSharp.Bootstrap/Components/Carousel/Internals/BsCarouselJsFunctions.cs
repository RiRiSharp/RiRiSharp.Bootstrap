using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using RiRiSharp.Bootstrap.Internals;

namespace RiRiSharp.Bootstrap.Components.Carousel.Internals;

internal class BsCarouselJsFunctions : IBsCarouselJsFunctions, IBsJsFunctionsWrapper
{
    public static string JsFileName => "carouselFunctions.js";
    private readonly IJSObjectReference _bsJsObjectRef;

    public BsCarouselJsFunctions(IJSObjectReference bsJsObjectRef)
    {
        _bsJsObjectRef = bsJsObjectRef;
    }

    internal const string MOVE_TO_SLIDE = "moveToSlide";

    public async Task MoveToSlideAsync(ElementReference carouselRef, int slideNumber)
    {
        await _bsJsObjectRef.InvokeVoidAsync(MOVE_TO_SLIDE, carouselRef, slideNumber);
    }

    internal const string MOVE_PREV = "movePrev";

    public async Task MovePrevAsync(ElementReference carouselRef)
    {
        await _bsJsObjectRef.InvokeVoidAsync(MOVE_PREV, carouselRef);
    }

    internal const string MOVE_NEXT = "moveNext";

    public async Task MoveNextAsync(ElementReference carouselRef)
    {
        await _bsJsObjectRef.InvokeVoidAsync(MOVE_NEXT, carouselRef);
    }

    internal const string CYCLE = "cycle";

    public async Task Cycle(ElementReference carouselRef)
    {
        await _bsJsObjectRef.InvokeVoidAsync(CYCLE, carouselRef);
    }

    internal const string PAUSE = "pause";

    public async Task Pause(ElementReference carouselRef)
    {
        await _bsJsObjectRef.InvokeVoidAsync(PAUSE, carouselRef);
    }

    internal const string ADD_CYCLE_CALLBACK = "addCycleCallback";

    public async Task AddCycleCallback(ElementReference carouselRef)
    {
        await _bsJsObjectRef.InvokeVoidAsync(ADD_CYCLE_CALLBACK, carouselRef);
    }

    internal const string REMOVE_CYCLE_CALLBACK = "removeCycleCallback";

    public async Task RemoveCycleCallback(ElementReference carouselRef)
    {
        await _bsJsObjectRef.InvokeVoidAsync(REMOVE_CYCLE_CALLBACK, carouselRef);
    }
}
