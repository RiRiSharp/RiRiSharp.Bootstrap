using NSubstitute;
using Wader.Components.Carousel;
using Wader.Components.Carousel.Internals;

namespace Wader.UnitTests.Components.Carousel;

public class BsCarouselControlPrevTests()
    : BsComponentTests<BsCarouselControlPrev>("""<button class="carousel-control-prev {0}" {1}></button>""")
{
    protected override Dictionary<string, string> AttributesForDefaultTests => new() { ["type"] = "button" };
    private readonly IBsCarouselContext _carouselContextMock = Substitute.For<IBsCarouselContext>();

    protected override void BindParameters(ComponentParameterCollectionBuilder<BsCarouselControlPrev> parameterBuilder)
    {
        base.BindParameters(parameterBuilder);
        _ = parameterBuilder.AddCascadingValue(_carouselContextMock);
    }

    [Fact]
    public void TypeCanBeOverriden()
    {
        TestForAllowingOverride("type");
    }
}
