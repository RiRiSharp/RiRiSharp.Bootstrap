using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.BaseComponents;
using RiRiSharp.Bootstrap.Components.Carousel.Internals;
using RiRiSharp.Bootstrap.Internals.Exceptions;

namespace RiRiSharp.Bootstrap.Components.Carousel;

public sealed partial class BsCarouselItem : BsChildContentComponent, IDisposable
{
    protected override string BsComponentClasses => "";

    [Parameter]
    public bool IsActive { get; set; }

    [Parameter]
    public int? Interval { get; set; }

    [CascadingParameter]
    private IBsCarouselInnerContext? CarouselInnerContext { get; set; }

    protected override void OnParametersSet()
    {
        base.OnParametersSet();
        if (CarouselInnerContext is null)
        {
            throw new CascadingParameterNotProvidedException(typeof(IBsCarouselInnerContext));
        }

        CarouselInnerContext.Register(this);
    }

    public void Dispose()
    {
        CarouselInnerContext!.Deregister(this);
    }
}
