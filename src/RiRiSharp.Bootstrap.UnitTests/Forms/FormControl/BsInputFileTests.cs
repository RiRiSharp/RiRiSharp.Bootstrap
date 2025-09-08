using RiRiSharp.Bootstrap.Forms;
using RiRiSharp.Bootstrap.Forms.FormControl;
using System;

namespace RiRiSharp.Bootstrap.UnitTests.Forms.FormControl;

public class BsInputFileTests : BunitContext
{
    private static string HtmlFormat => """<input class="form-control {0}" type="file" {1}>""";

    [Fact]
    public void DefaultWorks()
    {
        // Arrange
        ConfigureTestContext();

        // Act
        var cut = GetCut();

        // Assert
        var expectedMarkupString = string.Format(HtmlFormat, "", "");
        cut.MarkupMatches(expectedMarkupString);
    }
    
    [Fact]
    public void RefIsSet()
    {
        // Arrange
        ConfigureTestContext();

        // Act
        var cut = GetCut();

        // Assert
        Assert.NotEqual(default, cut.Instance.HtmlRef);
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
        var cut = GetCut(parameters =>
        {
            parameters.Add(x => x.Classes, classes);
        });

        // Assert
        var expectedMarkupString = string.Format(HtmlFormat, classes, "");
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
        var cut = GetCut(parameters =>
        {
            for (var i = 0; i < attributeKeys.Length; i++)
            {
                parameters.AddUnmatched(attributeKeys[i], attributeValues[i]);
            }
        });

        // Assert
        var expectedMarkupString = string.Format(HtmlFormat, "", expected);
        cut.MarkupMatches(expectedMarkupString);
    }
    
    [Theory]
    [InlineData(BsFormSize.Small, "form-control-sm")]
    [InlineData(BsFormSize.Regular, "")]
    [InlineData(BsFormSize.Large, "form-control-lg")]
    public void PassingParametersRendersIntoCorrectBsClass(BsFormSize formSize, string expectedClass)
    {
        // Arrange
        ConfigureTestContext();

        // Act
        var cut = GetCut(parameters => parameters.Add(x => x.FormSize, formSize));

        // Assert
        var expectedMarkupString = string.Format(HtmlFormat, expectedClass, "");
        cut.MarkupMatches(expectedMarkupString);
    }
    
    protected IRenderedComponent<BsInputFile> GetCut(Action<ComponentParameterCollectionBuilder<BsInputFile>> action = null)
    {
        return Render<BsInputFile>(parameters =>
        {
            BindParameters(parameters);
            action?.Invoke(parameters);
        });
    }

    protected virtual void BindParameters(ComponentParameterCollectionBuilder<BsInputFile> parameterBuilder)
    {

    }

    protected virtual void ConfigureTestContext()
    {
    }
}