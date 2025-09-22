using NSubstitute;
using RiRiSharp.Bootstrap.Components.Accordion;
using RiRiSharp.Bootstrap.Components.Accordion.Internals;

namespace RiRiSharp.Bootstrap.UnitTests.Components.Accordion;

public class BsAccordionTests() : BsComponentTests<BsAccordion>("""<div class="accordion {0}" {1}></div>""")
{
    private readonly IBsAccordionJsFunctions _accordionJsFunctionsMock = Substitute.For<IBsAccordionJsFunctions>();

    [Theory]
    [InlineData(BsAccordionDisplayStyle.Regular, "")]
    [InlineData(BsAccordionDisplayStyle.Flush, "accordion-flush")]
    public void DisplayStyleWorksCorrectly(BsAccordionDisplayStyle displayStyle, string expectedClass)
    {
        // Arrange
        ConfigureTestContext();

        // Act
        var cut = GetCut(parameters => parameters.Add(p => p.DisplayStyle, displayStyle));

        // Assert
        cut.MarkupMatches(GetExpectedHtml(expectedClass));
    }

    [Fact]
    public void AlwaysOpenSetsCommunicatesToContext()
    {
        // Arrange
        ConfigureTestContext();

        // Act
        var cut = GetCut(parameters => parameters.Add(p => p.AlwaysOpen, true));

        // Assert
        Assert.True(cut.Instance.AccordionContext.AlwaysOpen);
    }

    protected override void ConfigureTestContext()
    {
        _ = Services.AddSingleton(_accordionJsFunctionsMock);
    }
}
