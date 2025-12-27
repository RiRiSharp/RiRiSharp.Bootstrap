using RiRiSharp.Bootstrap.Components.Collapse;
using RiRiSharp.Bootstrap.Components.Dropdown;

namespace RiRiSharp.Bootstrap.UnitTests.Components.Dropdown;

public class BsDropdownTests() : BsComponentTests<BsDropdown>("""<div class="{0}" {1}></div>""")
{
    protected override string ClassesForDefaultTests => "dropdown";

    [Theory]
    [InlineData(BsDropDirection.Down, "dropdown")]
    [InlineData(BsDropDirection.Up, "dropup")]
    [InlineData(BsDropDirection.Start, "dropstart")]
    [InlineData(BsDropDirection.End, "dropend")]
    public void DirectionAddsCorrectClass(BsDropDirection direction, string expectedClass)
    {
        // Arrange
        ConfigureTestContext();

        // Act
        var cut = GetCut(parameters => parameters.Add(p => p.Drop, direction));

        // Assert
        var expectedMarkupString = GetExpectedHtml(expectedClass, AttributesForDefaultTests);
        cut.MarkupMatches(expectedMarkupString);
    }

    [Theory]
    [InlineData(BsDropdownMode.Regular, "")]
    [InlineData(BsDropdownMode.Split, "btn-group")]
    public void ModeAddsCorrectClass(BsDropdownMode dropdownMode, string expectedClass)
    {
        // Arrange
        ConfigureTestContext();

        // Act
        var cut = GetCut(parameters => parameters.Add(p => p.Mode, dropdownMode));

        // Assert
        var expectedMarkupString = GetExpectedHtml(
            $"{ClassesForDefaultTests} {expectedClass}",
            AttributesForDefaultTests
        );
        cut.MarkupMatches(expectedMarkupString);
    }
}
