using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.BaseComponents;
using System.Diagnostics.CodeAnalysis;

namespace RiRiSharp.Bootstrap.UnitTests;

public abstract class BsComponentTests<TComponent>([StringSyntax("Html")] string htmlFormat) : BunitContext
    where TComponent : ComponentBase, IBsComponent
{
    [Fact]
    public void DefaultWorks()
    {
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
        // Act
        var cut = Render<TComponent>(parameters =>
        {
            BuildParameters(parameters);
            parameters
                .Add(x => x.Classes, classes);
        });
        
        // Assert
        var expectedMarkupString = string.Format(htmlFormat, classes, "");
        cut.MarkupMatches(expectedMarkupString);
        
    }

    [Theory]
    [InlineData(new[] {"attributeKey"}, new [] {"attributeValue"}, 
        """
        attributeKey="attributeValue"
        """)]
    [InlineData(new[] {"attributeKey1", "attributeKey2"}, new [] {"attributeValue1", "attributeValue2"}, 
        """
        attributeKey1="attributeValue1" attributeKey2="attributeValue2"
        """)]
    public void ExtraAttributesWorks(string[] attributeKeys, string[] attributeValues, string expected)
    {
        // Act
        var cut = Render<TComponent>(parameters =>
        {
            BuildParameters(parameters);
            for (var i = 0; i < attributeKeys.Length; i++)
            {
                parameters
                    .AddUnmatched(attributeKeys[i], attributeValues[i]);
            }
        });
        
        // Assert
        var expectedMarkupString = string.Format(htmlFormat, "", expected);
        cut.MarkupMatches(expectedMarkupString);
    }
    
    protected virtual void BuildParameters(ComponentParameterCollectionBuilder<TComponent> parameterBuilder)
    {

    }
}