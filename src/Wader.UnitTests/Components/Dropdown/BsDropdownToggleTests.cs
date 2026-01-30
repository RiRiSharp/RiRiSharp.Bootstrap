using NSubstitute;
using Wader.Components.Buttons.Internals;
using Wader.Components.Dropdown;

namespace Wader.UnitTests.Components.Dropdown;

public class BsDropdownToggleTests()
    : BsComponentTests<BsDropdownToggle>(
        """<button class="btn btn-primary dropdown-toggle {0}" data-bs-toggle="dropdown" {1}></div>"""
    )
{
    private readonly IBsButtonJsFunctions _buttonJsFunctionsMock = Substitute.For<IBsButtonJsFunctions>();

    protected override Dictionary<string, string> AttributesForDefaultTests =>
        new() { ["type"] = "button", ["aria-expanded"] = "false" };

    [Theory]
    [InlineData(BsDropdownMode.Regular, "")]
    [InlineData(BsDropdownMode.Split, "dropdown-toggle-split")]
    public void ModeAddsCorrectClass(BsDropdownMode dropdownMode, string? expectedClass)
    {
        // Arrange
        ConfigureTestContext();

        // Act
        var cut = GetCut(parameters => parameters.AddCascadingValue(dropdownMode));

        // Assert
        var expectedMarkupString = GetExpectedHtml(
            $"{ClassesForDefaultTests} {expectedClass}",
            AttributesForDefaultTests
        );
        cut.MarkupMatches(expectedMarkupString);
    }

    [Fact]
    public void ButtonTypeCanBeOverriden()
    {
        TestForAllowingOverride("type");
    }

    [Fact]
    public void AriaExpandedCanBeOverriden()
    {
        TestForAllowingOverride("aria-expanded");
    }

    [Fact]
    public void DataBsToggleCannotBeOverridden()
    {
        TestForDisallowingOverride("data-bs-toggle");
    }

    protected override void ConfigureTestContext()
    {
        _ = Services.AddSingleton(_buttonJsFunctionsMock);
    }
}
