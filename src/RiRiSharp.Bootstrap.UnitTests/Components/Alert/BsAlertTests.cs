using NSubstitute;
using RiRiSharp.Bootstrap.Components.Alert;
using RiRiSharp.Bootstrap.Components.Alert.Internals;

namespace RiRiSharp.Bootstrap.UnitTests.Components.Alert;

public class BsAlertTests() : BsComponentTests<BsAlert>("""<div role="alert" class="alert {0}" {1}></div>""")
{
    protected override string ClassesForDefaultTests => "alert-primary fade show";
    private readonly IBsAlertJsFunctions _alertJsFunctionsMock = Substitute.For<IBsAlertJsFunctions>();

    [Theory]
    [InlineData(BsAlertVariant.Primary, "alert-primary")]
    [InlineData(BsAlertVariant.Secondary, "alert-secondary")]
    [InlineData(BsAlertVariant.Success, "alert-success")]
    [InlineData(BsAlertVariant.Danger, "alert-danger")]
    [InlineData(BsAlertVariant.Warning, "alert-warning")]
    [InlineData(BsAlertVariant.Info, "alert-info")]
    [InlineData(BsAlertVariant.Light, "alert-light")]
    [InlineData(BsAlertVariant.Dark, "alert-dark")]
    public void VariantParameterAppliesCorrectClass(BsAlertVariant variant, string expectedClass)
    {
        // Arrange
        ConfigureTestContext();

        // Act
        var cut = GetCut(parameters => parameters.Add(p => p.Variant, variant));

        // Assert
        var expectedMarkupString = GetExpectedHtml($"{expectedClass} fade show", AttributesForDefaultTests);
        cut.MarkupMatches(expectedMarkupString);
    }

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public void DismissibleAppliesCorrectClass(bool dismissible)
    {
        // Arrange
        ConfigureTestContext();

        // Act
        var cut = GetCut(parameters => parameters.Add(p => p.Dismissable, dismissible));

        // Assert
        var dismissClass = dismissible ? "alert-dismissible" : "";
        var expectedMarkupString = GetExpectedHtml($"{ClassesForDefaultTests} {dismissClass}");
        cut.MarkupMatches(expectedMarkupString);
    }

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public void AnimateAppliesCorrectClass(bool animate)
    {
        // Arrange
        ConfigureTestContext();

        // Act
        var cut = GetCut(parameters => parameters.Add(p => p.Animate, animate));

        // Assert
        var animateClass = animate ? "fade show" : "";
        var expectedMarkupString = GetExpectedHtml($"alert-primary {animateClass}");
        cut.MarkupMatches(expectedMarkupString);
    }

    protected override void ConfigureTestContext()
    {
        _ = Services.AddSingleton(_alertJsFunctionsMock);
    }
}
