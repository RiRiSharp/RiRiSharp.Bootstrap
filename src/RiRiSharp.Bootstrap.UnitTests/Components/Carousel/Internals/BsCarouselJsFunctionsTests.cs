using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using NSubstitute;
using RiRiSharp.Bootstrap.Components.Carousel.Internals;

namespace RiRiSharp.Bootstrap.UnitTests.Components.Carousel.Internals;

public class BsCarouselJsFunctionsTests
{
    [Fact]
    public async Task MoveToSlideCallsCorrectJsFunctionAsync()
    {
        // Arrange
        var jsObj = Substitute.For<IJSObjectReference>();
        await using var sut = new BsCarouselJsFunctions(jsObj);
        ElementReference carouselRef = default;
        const int slideNumber = 1337;

        // Act
        await sut.MoveToSlideAsync(carouselRef, slideNumber);

        // Assert
        AssertJsInterop.Calls(jsObj, BsCarouselJsFunctions.MOVE_TO_SLIDE, carouselRef, slideNumber);
    }
}
