using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using RiRiSharp.Bootstrap.BaseComponents;
using RiRiSharp.Bootstrap.Components.Carousel.Internals;
using RiRiSharp.Bootstrap.Internals.Exceptions;

namespace RiRiSharp.Bootstrap.Components.Carousel;

public partial class BsCarouselControlPrev : BsChildContentComponent
{
    protected override string BsComponentClasses => "carousel-control-prev";

    [CascadingParameter]
    private IBsCarouselContext? CarouselContext { get; set; }

    protected override void OnParametersSet()
    {
        base.OnParametersSet();
        if (CarouselContext is null)
        {
            throw new BsCascadingParameterNotProvidedException(typeof(IBsCarouselContext));
        }
    }

    public async Task PrevAsync()
    {
        await CarouselContext!.MovePrevAsync();
    }
}
