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

    [Fact]
    public void DefaultWorks()
    {
        // Arrange
        ConfigureTestContext();

        // Act
        var cut = GetCut();

        // Assert
        var expectedMarkupString = GetExpectedHtml("", "");
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

    [
        Theory,
        InlineData(null),
        InlineData(""),
        InlineData("aclass"),
        InlineData("aclass bclass"),
        InlineData("aclass blass class")
    ]
    public void PassingClassesWorks(string classes)
    {
        // Arrange
        ConfigureTestContext();

        // Act
        var cut = GetCut(parameters => parameters.Add(x => x.Classes, classes));

        // Assert
        var expectedMarkupString = GetExpectedHtml(classes, "");
        cut.MarkupMatches(expectedMarkupString);
    }

    [
        Theory,
        InlineData(
            new[] { "attributeKey" },
            new[] { "attributeValue" },
            """
                attributeKey="attributeValue"
                """
        ),
        InlineData(
            new[] { "attributeKey1", "attributeKey2" },
            new[] { "attributeValue1", "attributeValue2" },
            """
                attributeKey1="attributeValue1" attributeKey2="attributeValue2"
                """
        )
    ]
    public void ExtraAttributesWorks(string[] attributeKeys, string[] attributeValues, string expected)
    {
        // Arrange
        ConfigureTestContext();

        // Act
        var cut = GetCut(parameters =>
        {
            for (var i = 0; i < attributeKeys.Length; i++)
            {
                _ = parameters.AddUnmatched(attributeKeys[i], attributeValues[i]);
            }
        });

        // Assert
        var expectedMarkupString = GetExpectedHtml("", expected);
        cut.MarkupMatches(expectedMarkupString);
    }

    protected virtual IRenderedComponent<TComponent> GetCut(
        Action<ComponentParameterCollectionBuilder<TComponent>> action = null
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

    protected virtual string GetExpectedHtml(string classes = null, string attributes = null)
    {
        return string.Format(CultureInfo.InvariantCulture, HtmlFormatCache, classes, attributes);
    }
}
