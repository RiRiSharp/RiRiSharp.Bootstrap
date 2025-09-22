using NSubstitute;
using RiRiSharp.Bootstrap.Components.Buttons;
using RiRiSharp.Bootstrap.Components.Buttons.Internals;

namespace RiRiSharp.Bootstrap.UnitTests.Components.Buttons;

public class BsToggleButtonTests() : BsComponentTests<BsToggleButton>("""<button class="btn {0}" {1}></button>""")
{
    private readonly IBsButtonJsFunctions _buttonJsFunctionsMock = Substitute.For<IBsButtonJsFunctions>();

    protected override string ClassesForDefaultTests => "btn-primary";
    protected override Dictionary<string, string> AttributesForDefaultTests => new() { ["type"] = "button" };

    [Theory]
    [InlineData(BsButtonVariant.None, "")]
    [InlineData(BsButtonVariant.Primary, "btn-primary")]
    [InlineData(BsButtonVariant.Secondary, "btn-secondary")]
    [InlineData(BsButtonVariant.Success, "btn-success")]
    [InlineData(BsButtonVariant.Danger, "btn-danger")]
    [InlineData(BsButtonVariant.Warning, "btn-warning")]
    [InlineData(BsButtonVariant.Info, "btn-info")]
    [InlineData(BsButtonVariant.Light, "btn-light")]
    [InlineData(BsButtonVariant.Dark, "btn-dark")]
    [InlineData(BsButtonVariant.Link, "btn-link")]
    public void VariantParameterAppliesCorrectClass(BsButtonVariant variant, string expectedClass)
    {
        // Arrange
        ConfigureTestContext();

        // Act
        var cut = GetCut(parameters => parameters.Add(p => p.Variant, variant));

        // Assert
        var expectedMarkupString = GetExpectedHtml(expectedClass, AttributesForDefaultTests);
        cut.MarkupMatches(expectedMarkupString);
    }

    [Theory]
    [InlineData(BsButtonSize.Regular, "")]
    [InlineData(BsButtonSize.Small, "btn-sm")]
    [InlineData(BsButtonSize.Large, "btn-lg")]
    public void SizeParameterAppliesCorrectClass(BsButtonSize size, string expectedClass)
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
        cut.MarkupMatches(expectedMarkupString);
    }

    [Fact]
    public void ButtonTypeCanBeOverriden()
    {
        TestForAllowingOverride("type");
    }

    protected override void ConfigureTestContext()
    {
        _ = Services.AddSingleton(_buttonJsFunctionsMock);
    }
}
