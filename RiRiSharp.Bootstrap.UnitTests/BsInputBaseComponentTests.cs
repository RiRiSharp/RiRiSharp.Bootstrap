using RiRiSharp.Bootstrap.Forms;
using System.Diagnostics.CodeAnalysis;

namespace RiRiSharp.Bootstrap.UnitTests;

public abstract class BsInputBaseComponentTests<TComponent, TValue>([StringSyntax("Html")] string htmlFormat)
    where TComponent : BsInputBase<TValue>
{
    [Fact]
    public void DefaultWorks()
    {
        // Arrange
        using var ctx = new TestContext();
        TValue value = default;

        // Act
        var cut = ctx.RenderComponent<TComponent>(parameters => parameters.Bind(
            p => p.Value, value, newValue => value = newValue));

        // Assert
        var expectedMarkupString = string.Format(htmlFormat, string.Empty, string.Empty);
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
        using var ctx = new TestContext();
        TValue value = default;

        // Act
        var cut = ctx.RenderComponent<TComponent>(parameters => parameters
            .Add(x => x.Classes, classes)
            .Bind(
                p => p.Value, value, newValue => value = newValue));

        // Assert
        var expectedMarkupString = string.Format(htmlFormat, classes, string.Empty);
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
        using var ctx = new TestContext();
        TValue value = default;
        
        // Act
        var cut = ctx.RenderComponent<TComponent>(parameters =>
        {
            for (var i = 0; i < attributeKeys.Length; i++)
            {
                parameters
                    .AddUnmatched(attributeKeys[i], attributeValues[i]);
            }

            parameters.Bind(p => p.Value, value, newValue => value = newValue);
        });

        // Assert
        var expectedMarkupString = string.Format(htmlFormat, string.Empty, expected);
        cut.MarkupMatches(expectedMarkupString);
    }
}