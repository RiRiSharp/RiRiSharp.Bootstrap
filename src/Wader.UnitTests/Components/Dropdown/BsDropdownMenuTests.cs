using Wader.Components.Dropdown;
using Wader.Shared;

namespace Wader.UnitTests.Components.Dropdown;

public class BsDropdownMenuTests() : BsComponentTests<BsDropdownMenu>("""<ul class="dropdown-menu {0}" {1}></ul>""")
{
    [Theory]
    [InlineData(BsDirection.Start, "")]
    [InlineData(BsDirection.End, "dropdown-menu-end")]
    public void MenuDirectionAddsCorrectClass(BsDirection direction, string expectedClass)
    {
        // Arrange
        ConfigureTestContext();

        // Act
        var cut = GetCut(parameters => parameters.Add(p => p.Direction, direction));

        // Assert
        var expectedMarkupString = GetExpectedHtml(expectedClass, AttributesForDefaultTests);
        cut.MarkupMatches(expectedMarkupString);
    }
}
