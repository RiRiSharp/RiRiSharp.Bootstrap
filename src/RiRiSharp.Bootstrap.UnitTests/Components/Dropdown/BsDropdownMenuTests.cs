using RiRiSharp.Bootstrap.Components.Dropdown;

namespace RiRiSharp.Bootstrap.UnitTests.Components.Dropdown;

public class BsDropdownMenuTests() : BsComponentTests<BsDropdownMenu>("""<ul class="dropdown-menu {0}" {1}></ul>""")
{
    [Theory]
    [InlineData(BsDropdownMenuDirection.Start, "")]
    [InlineData(BsDropdownMenuDirection.End, "dropdown-menu-end")]
    public void MenuDirectionAddsCorrectClass(BsDropdownMenuDirection direction, string expectedClass)
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
