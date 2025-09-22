using RiRiSharp.Bootstrap.Components.Breadcrumb;

namespace RiRiSharp.Bootstrap.UnitTests.Components.Breadcrumb;

public class BsBreadcrumbItemTests()
    : BsComponentTests<BsBreadcrumbItem>("""<li class="breadcrumb-item {0}" {1}></li>""")
{
    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public void DismissibleAppliesCorrectClass(bool active)
    {
        // Arrange
        ConfigureTestContext();

        // Act
        var cut = GetCut(parameters => parameters.Add(p => p.Active, active));

        // Assert
        var dismissClass = active ? "active" : "";
        var expectedMarkupString = GetExpectedHtml(dismissClass);
        cut.MarkupMatches(expectedMarkupString);
    }
}
