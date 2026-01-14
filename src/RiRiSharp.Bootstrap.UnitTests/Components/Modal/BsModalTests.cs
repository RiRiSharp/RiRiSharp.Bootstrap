using NSubstitute;
using RiRiSharp.Bootstrap.Components.Modal;
using RiRiSharp.Bootstrap.Components.Modal.Internals;

namespace RiRiSharp.Bootstrap.UnitTests.Components.Modal;

public class BsModalTests() : BsComponentTests<BsModal>("""<div class="modal {0}" {1}></div>""")
{
    protected override string ClassesForDefaultTests => "fade";

    protected override Dictionary<string, string> AttributesForDefaultTests =>
        new() { ["tabindex"] = "-1", ["aria-hidden"] = "true" };

    private readonly IBsModalJsFunctions _collapseJsFunctionsMock = Substitute.For<IBsModalJsFunctions>();

    [Theory]
    [InlineData(BsModalBackdrop.Regular, null, null)]
    [InlineData(BsModalBackdrop.Static, "static", "false")]
    public void BackdropAddsCorrectDataBsAttributes(
        BsModalBackdrop backdrop,
        string? backdropAttributeValue,
        string? keyboardAttributeValue
    )
    {
        // Arrange
        ConfigureTestContext();

        var attributes = AttributesForDefaultTests;
        if (backdropAttributeValue is not null)
        {
            attributes["data-bs-backdrop"] = backdropAttributeValue;
        }

        if (keyboardAttributeValue is not null)
        {
            attributes["data-bs-keyboard"] = keyboardAttributeValue;
        }

        // Act
        var cut = GetCut(parameters => parameters.Add(x => x.Backdrop, backdrop));

        // Assert
        var expectedMarkupString = GetExpectedHtml(ClassesForDefaultTests, attributes);
        cut.MarkupMatches(expectedMarkupString);
    }

    [Theory]
    [InlineData(true, "fade")]
    [InlineData(false, "")]
    public void FadingAddsCorrectClass(bool fade, string expectedClass)
    {
        // Arrange
        ConfigureTestContext();

        // Act
        var cut = GetCut(parameters => parameters.Add(x => x.Fade, fade));

        // Assert
        var expectedMarkupString = GetExpectedHtml(expectedClass, AttributesForDefaultTests);
        cut.MarkupMatches(expectedMarkupString);
    }

    [Fact]
    public void TabIndexCanBeOverriden()
    {
        TestForAllowingOverride("tab-index");
    }

    [Fact]
    public void AriaHiddenCanBeOverriden()
    {
        TestForAllowingOverride("aria-hidden");
    }

    [Fact]
    public void ModalContextIsCascading()
    {
        TestForCascadingValue<IBsModalContext>();
    }

    protected override void ConfigureTestContext()
    {
        _ = Services.AddSingleton(_collapseJsFunctionsMock);
    }
}
