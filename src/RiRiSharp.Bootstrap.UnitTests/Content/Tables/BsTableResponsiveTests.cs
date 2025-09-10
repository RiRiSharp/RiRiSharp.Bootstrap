using RiRiSharp.Bootstrap.Content.Abbreviations;
using RiRiSharp.Bootstrap.Content.Tables;

namespace RiRiSharp.Bootstrap.UnitTests.Content.Tables;

public class BsTableResponsiveTests()
    : BsComponentTests<BsTableResponsive>("""<div class="table-responsive {0}" {1}></div>""")
{
    [Theory]
    [InlineData(BsTableBreakpoint.Default, "table-responsive")]
    [InlineData(BsTableBreakpoint.Sm, "table-responsive-sm")]
    [InlineData(BsTableBreakpoint.Md, "table-responsive-md")]
    [InlineData(BsTableBreakpoint.Lg, "table-responsive-lg")]
    [InlineData(BsTableBreakpoint.Xl, "table-responsive-xl")]
    [InlineData(BsTableBreakpoint.Xxl, "table-responsive-xxl")]
    public void TableOptionsWorks(BsTableBreakpoint options, string expectedClass)
    {
        // Arrange + Act
        var cut = GetCut(parameters => parameters.Add(p => p.Breakpoint, options));

        // Assert
        cut.MarkupMatches($"""<div class="{expectedClass}"></div>""");
    }
}
