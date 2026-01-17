using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Wader.BaseComponents;
using Wader.Components.Carousel.Internals;
using Wader.Internals.Exceptions;

namespace Wader.Components.Carousel;

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
