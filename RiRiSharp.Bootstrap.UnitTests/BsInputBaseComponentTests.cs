using Microsoft.AspNetCore.Components.Forms;
using System.Diagnostics.CodeAnalysis;

namespace RiRiSharp.Bootstrap.UnitTests;

public abstract class BsInputBaseComponentTests<TComponent, TValue>([StringSyntax("Html")] string htmlFormat) : BunitContext
    where TComponent : InputBase<TValue>, IBsComponent
{
    protected string HtmlFormat => htmlFormat;

    [Fact]
    public void DefaultWorks()
    {
        // Arrange
        ConfigureTestContext();

        // Act
        var cut = Render<TComponent>(BuildParameters);

        // Assert
        var expectedMarkupString = string.Format(htmlFormat, "", "");
        cut.MarkupMatches(expectedMarkupString);
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData("aclass")]
    [InlineData("aclass bclass")]
    [InlineData("aclass blass class")]
    public void PassingClassesWorks(string classes)
    {
        // Arrange
        ConfigureTestContext();

        // Act
        var cut = Render<TComponent>(parameters =>
        {
            BuildParameters(parameters);
            parameters.Add(x => x.Classes, classes);
        });

        // Assert
        var expectedMarkupString = string.Format(htmlFormat, classes, "");
        cut.MarkupMatches(expectedMarkupString);
    }

    [Theory]
    [InlineData(new[] { "attributeKey" }, new[] { "attributeValue" },
        """
        attributeKey="attributeValue"
        """)]
    [InlineData(new[] { "attributeKey1", "attributeKey2" }, new[] { "attributeValue1", "attributeValue2" },
        """
        attributeKey1="attributeValue1" attributeKey2="attributeValue2"
        """)]
    public void ExtraAttributesWorks(string[] attributeKeys, string[] attributeValues, string expected)
    {
        // Arrange
        ConfigureTestContext();

        // Act
        var cut = Render<TComponent>(parameters =>
        {
            BuildParameters(parameters);
            for (var i = 0; i < attributeKeys.Length; i++)
            {
                parameters.AddUnmatched(attributeKeys[i], attributeValues[i]);
            }
        });

        // Assert
        var expectedMarkupString = string.Format(htmlFormat, "", expected);
        cut.MarkupMatches(expectedMarkupString);
    }

    protected virtual void BuildParameters(ComponentParameterCollectionBuilder<TComponent> parameterBuilder)
    {
        TValue value = default;
        parameterBuilder.Bind(p => p.Value, value, newValue => value = newValue);
    }

    protected virtual void ConfigureTestContext()
    {
        
    }
}