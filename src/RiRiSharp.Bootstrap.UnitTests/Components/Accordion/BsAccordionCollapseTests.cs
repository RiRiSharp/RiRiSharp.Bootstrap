using NSubstitute;
using RiRiSharp.Bootstrap.Components.Accordion;
using RiRiSharp.Bootstrap.Components.Accordion.Internals;

namespace RiRiSharp.Bootstrap.UnitTests.Components.Accordion;

public class BsAccordionCollapseTests()
    : BsComponentTests<BsAccordionCollapse>("""<div class="accordion-collapse collapse {0}" {1}></div>""")
{
    protected override string ClassesForDefaultTests => "show";

    private readonly IBsAccordionJsFunctions _accordionJsFunctionsMock = Substitute.For<IBsAccordionJsFunctions>();
    private readonly IBsAccordionItemContext _accordionItemContextMock = Substitute.For<IBsAccordionItemContext>();

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public async Task CollapsedParametersWorksAsExpectedAsync(bool isCollapsed)
    {
        // Arrange
        ConfigureTestContext();
        _ = _accordionItemContextMock.Collapsed.Returns(isCollapsed);

        // Act
        var cut = GetCut();
        await cut.InvokeAsync(() => cut.Instance.UpdateCollapseState(isCollapsed));

        // Assert
        var collapsingClass = isCollapsed ? "" : "show";
        cut.MarkupMatches(GetExpectedHtml(collapsingClass, ""));
    }

    protected override void BindParameters(ComponentParameterCollectionBuilder<BsAccordionCollapse> parameterBuilder)
    {
        base.BindParameters(parameterBuilder);
        _ = parameterBuilder.AddCascadingValue(_accordionItemContextMock);
    }

    protected override void ConfigureTestContext()
    {
        _ = Services.AddSingleton(_accordionJsFunctionsMock);
    }
}
