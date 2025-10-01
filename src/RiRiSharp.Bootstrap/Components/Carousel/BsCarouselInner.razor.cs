using RiRiSharp.Bootstrap.BaseComponents;
using RiRiSharp.Bootstrap.Components.Carousel.Internals;

namespace RiRiSharp.Bootstrap.Components.Carousel;

public partial class BsCarouselInner : BsChildContentComponent
{
    public IBsCarouselInnerContext? CarouselInnerContext { get; set; }
    protected override string BsComponentClasses => "carousel-inner";

    protected override void OnInitialized()
    {
        base.OnInitialized();
        CarouselInnerContext = new BsCarouselInnerContext();
    }
}
