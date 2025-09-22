using RiRiSharp.Bootstrap.Components.Buttons;

namespace RiRiSharp.Bootstrap.UnitTests.Components.Buttons;

public class BsButtonLabelTests() : BsComponentTests<BsButtonLabel>("""<label class="btn {0}" {1}></label>""")
{
    protected override string ClassesForDefaultTests => "btn-primary";

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
}
