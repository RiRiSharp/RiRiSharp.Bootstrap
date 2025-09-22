using RiRiSharp.Bootstrap.Components.ButtonGroup;
using RiRiSharp.Bootstrap.Components.Buttons;

namespace RiRiSharp.Bootstrap.UnitTests.Components.ButtonGroup;

public class BsButtonGroupVerticalTests()
    : BsComponentTests<BsButtonGroupVertical>("""<div class="btn-group-vertical {0}" {1}></div>""")
{
    protected override string AttributesForDefaultTests => "role=\"group\"";

    [Theory]
    [InlineData(BsButtonGroupSize.Regular, "")]
    [InlineData(BsButtonGroupSize.Small, "btn-group-sm")]
    [InlineData(BsButtonGroupSize.Large, "btn-group-lg")]
    public void SizeParameterAppliesCorrectClass(BsButtonGroupSize size, string expectedClass)
    {
        // Arrange
        ConfigureTestContext();

        // Act
        var cut = GetCut(parameters => parameters.Add(p => p.Size, size));

        // Assert
        var expectedMarkupString = GetExpectedHtml(
            $"{ClassesForDefaultTests} {expectedClass}",
            AttributesForDefaultTests
        );
        cut.MarkupMatches(expectedMarkupString, AttributesForDefaultTests);
    }

    [Fact]
    public void GroupRoleCanBeOverriden()
    {
        // Arrange
        ConfigureTestContext();

        // Act
        var cut = GetCut(parameters => parameters.AddUnmatched("role", "toolbar"));

        // Assert
        cut.MarkupMatches(GetExpectedHtml(ClassesForDefaultTests, """role="toolbar" """));
    }
}
