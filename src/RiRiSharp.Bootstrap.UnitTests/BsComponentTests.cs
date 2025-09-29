using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Text;
using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.BaseComponents;

namespace RiRiSharp.Bootstrap.UnitTests;

public abstract class BsComponentTests<TComponent>([StringSyntax("Html")] string htmlFormat) : BunitContext
    where TComponent : ComponentBase, IBsComponent
{
    protected CompositeFormat HtmlFormatCache => CompositeFormat.Parse(htmlFormat);
    protected virtual bool SkipRefCheck => false;
    protected virtual string ClassesForDefaultTests => "";
    protected virtual Dictionary<string, string> AttributesForDefaultTests => [];

    [Fact]
    public void DefaultWorks()
    {
        // Arrange
        ConfigureTestContext();

        // Act
        var cut = GetCut();

        // Assert
        var expectedMarkupString = GetExpectedHtml(ClassesForDefaultTests, AttributesForDefaultTests);
        cut.MarkupMatches(expectedMarkupString);
    }

    [Fact]
    public void RefIsSet()
    {
        // Arrange
        if (SkipRefCheck)
        {
            return;
        }

        ConfigureTestContext();

        // Act
        var cut = GetCut();

        // Assert
        Assert.NotEqual(default, cut.Instance.HtmlRef);
    }

    [Theory]
    [InlineData("")]
    [InlineData("aclass")]
    [InlineData("aclass bclass")]
    [InlineData("aclass blass class")]
    public void PassingClassesWorks(string? classes)
    {
        // Arrange
        ConfigureTestContext();
        classes += " " + ClassesForDefaultTests;

        // Act
        var cut = GetCut(parameters => parameters.AddUnmatched("class", classes));

        // Assert
        var expectedMarkupString = GetExpectedHtml(classes, AttributesForDefaultTests);
        cut.MarkupMatches(expectedMarkupString);
    }

    [Theory]
    [InlineData(new[] { "attributeKey" }, new[] { "attributeValue" }, """attributeKey="attributeValue" """)]
    [InlineData(
        new[] { "attributeKey1", "attributeKey2" },
        new[] { "attributeValue1", "attributeValue2" },
        """ attributeKey1="attributeValue1" attributeKey2="attributeValue2" """
    )]
    public void ExtraAttributesWorks(string[] attributeKeys, string[] attributeValues, string expected)
    {
        // Arrange
        ConfigureTestContext();
        expected += " " + AttributesForDefaultTests.ToAttributeKeyValueString();

        // Act
        var cut = GetCut(parameters =>
        {
            for (var i = 0; i < attributeKeys.Length; i++)
            {
                _ = parameters.AddUnmatched(attributeKeys[i], attributeValues[i]);
            }
        });

        // Assert
        var expectedMarkupString = GetExpectedHtml(ClassesForDefaultTests, expected);
        cut.MarkupMatches(expectedMarkupString);
    }

    protected void TestForAllowingOverride(string attributeKey)
    {
        // Arrange
        ConfigureTestContext();
        const string value = "some-unique-value";
        var attributes = AttributesForDefaultTests;
        attributes[attributeKey] = value;

        // Act
        var cut = GetCut(parameters => parameters.AddUnmatched(attributeKey, value));

        // Assert
        cut.MarkupMatches(GetExpectedHtml(ClassesForDefaultTests, attributes));
    }

    protected void TestForDisallowingOverride(string attributeKey)
    {
        // Arrange
        ConfigureTestContext();
        const string value = "some-unique-value";

        // Act
        var cut = GetCut(parameters => parameters.AddUnmatched(attributeKey, value));

        // Assert
        cut.MarkupMatches(GetExpectedHtml(ClassesForDefaultTests, AttributesForDefaultTests));
    }

    protected virtual IRenderedComponent<TComponent> GetCut(
        Action<ComponentParameterCollectionBuilder<TComponent>>? action = null
    )
    {
        return Render<TComponent>(parameters =>
        {
            BindParameters(parameters);
            action?.Invoke(parameters);
        });
    }

    protected virtual void BindParameters(ComponentParameterCollectionBuilder<TComponent> parameterBuilder) { }

    protected virtual void ConfigureTestContext() { }

    protected virtual string GetExpectedHtml(string? classes = null)
    {
        return string.Format(CultureInfo.InvariantCulture, HtmlFormatCache, classes, null);
    }

    protected virtual string GetExpectedHtml(string? classes, string? attributes)
    {
        return string.Format(CultureInfo.InvariantCulture, HtmlFormatCache, classes, attributes);
    }

    protected virtual string GetExpectedHtml(string? classes, Dictionary<string, string>? attributes)
    {
        attributes ??= [];
        var attributeString = attributes.ToAttributeKeyValueString();
        return GetExpectedHtml(classes, attributeString);
    }
}
