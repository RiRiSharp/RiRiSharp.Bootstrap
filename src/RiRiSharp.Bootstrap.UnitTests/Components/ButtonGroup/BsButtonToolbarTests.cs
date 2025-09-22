using RiRiSharp.Bootstrap.Components.ButtonGroup;
using RiRiSharp.Bootstrap.Components.Buttons;

namespace RiRiSharp.Bootstrap.UnitTests.Components.ButtonGroup;

public class BsButtonToolbarTests() : BsComponentTests<BsButtonToolbar>("""<div class="btn-toolbar {0}" {1}></div>""")
{
    protected override string AttributesForDefaultTests => "role=\"toolbar\"";

    [Fact]
    public void ToolbarRoleCanBeOverriden()
    {
        // Arrange
        ConfigureTestContext();

        // Act
        var cut = GetCut(parameters => parameters.AddUnmatched("role", "group"));

        // Assert
        cut.MarkupMatches(GetExpectedHtml(ClassesForDefaultTests, """role="group" """));
    }
}
