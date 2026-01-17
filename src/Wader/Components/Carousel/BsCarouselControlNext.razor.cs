using Microsoft.AspNetCore.Components;
using Wader.BaseComponents;
using Wader.Components.Carousel.Internals;
using Wader.Internals.Exceptions;

namespace Wader.Components.Carousel;

public partial class BsCarouselControlNext : BsChildContentComponent
{
    protected override string BsComponentClasses => "carousel-control-next";

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

    public async Task NextAsync()
    {
        await CarouselContext!.MoveNextAsync();
    }
}
