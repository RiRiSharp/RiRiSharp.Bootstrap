using Wader.Components.Pagination;

namespace Wader.UnitTests.Components.Pagination;

public class BsPageLinkTests() : BsComponentTests<BsPageLink>("""<a class="page-link {0}" {1}></a>""")
{
    [Theory]
    [InlineData(BsPageLinkType.Anchor, "a")]
    [InlineData(BsPageLinkType.Span, "span")]
    public void TypeCreatesCorrectTag(BsPageLinkType type, string expectedTag)
    {
        // Arrange
        ConfigureTestContext();

        // Act
        var cut = GetCut(parameters => parameters.Add(x => x.Type, type));

        // Assert
        cut.MarkupMatches($"<{expectedTag} diff:ignoreAttributes></{expectedTag}>");
    }
}
