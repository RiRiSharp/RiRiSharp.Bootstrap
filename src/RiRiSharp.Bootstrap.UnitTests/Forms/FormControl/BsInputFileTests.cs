using System.Globalization;
using System.Text;
using RiRiSharp.Bootstrap.Forms;
using RiRiSharp.Bootstrap.Forms.FormControl;

namespace RiRiSharp.Bootstrap.UnitTests.Forms.FormControl;

public class BsInputFileTests : BunitContext
{
    private static string HtmlFormat => """<input class="form-control {0}" type="file" {1}>""";
    private static CompositeFormat HtmlFormatCache => CompositeFormat.Parse(HtmlFormat);

    [Fact]
    public void DefaultWorks()
    {
        // Arrange
        ConfigureTestContext();

        // Act
        var cut = GetCut();

        // Assert
        cut.MarkupMatches(GetExpectedHtml("", ""));
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
        var cut = GetCut(parameters => parameters.Add(x => x.Classes, classes));

        // Assert
        cut.MarkupMatches(GetExpectedHtml(classes, ""));
    }

    [Theory]
    [InlineData(
        new[] { "attributeKey" },
        new[] { "attributeValue" },
        """
            attributeKey="attributeValue"
            """
    )]
    [InlineData(
        new[] { "attributeKey1", "attributeKey2" },
        new[] { "attributeValue1", "attributeValue2" },
        """
            attributeKey1="attributeValue1" attributeKey2="attributeValue2"
            """
    )]
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
        cut.MarkupMatches(GetExpectedHtml("", expected));
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
        cut.MarkupMatches(GetExpectedHtml(expectedClass, ""));
    }

    protected IRenderedComponent<BsInputFile> GetCut(
        Action<ComponentParameterCollectionBuilder<BsInputFile>> action = null
    )
    {
        return Render<BsInputFile>(parameters =>
        {
            BindParameters(parameters);
            action?.Invoke(parameters);
        });
    }

    protected virtual string GetExpectedHtml(string classes = null, string attributes = null)
    {
        return string.Format(CultureInfo.InvariantCulture, HtmlFormatCache, classes, attributes);
    }

    protected virtual void BindParameters(ComponentParameterCollectionBuilder<BsInputFile> parameterBuilder) { }

    protected virtual void ConfigureTestContext() { }
}
