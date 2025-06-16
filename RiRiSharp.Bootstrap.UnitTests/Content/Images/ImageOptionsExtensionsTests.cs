using RiRiSharp.Bootstrap.Content.Images;

namespace RiRiSharp.Bootstrap.UnitTests.Content.Images;

public class ImageOptionsExtensionsTests
{
    [Theory]
    [InlineData(ImageOptions.None, "")]
    [InlineData(ImageOptions.Fluid, "img-fluid")]
    [InlineData(ImageOptions.Thumbnail, "img-thumbnail")]
    [InlineData(ImageOptions.Rounded, "rounded")]
    [InlineData(ImageOptions.Figure, "figure-img")]
    [InlineData(ImageOptions.Fluid | ImageOptions.Rounded, "img-fluid rounded")]
    [InlineData(ImageOptions.Thumbnail | ImageOptions.Figure, "img-thumbnail figure-img")]
    [InlineData(ImageOptions.Fluid | ImageOptions.Thumbnail | ImageOptions.Rounded | ImageOptions.Figure,
        "img-fluid img-thumbnail rounded figure-img")]
    public void ImageOptionsGeneratesCorrectClasses(ImageOptions imageOptions, string expectedClass)
    {
        var generatedClass = imageOptions.ToBootstrapClass();
        Assert.Equal(expectedClass, generatedClass);
    }
}