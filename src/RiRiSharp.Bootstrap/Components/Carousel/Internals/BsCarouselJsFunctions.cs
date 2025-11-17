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
}
