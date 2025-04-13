using System.Text;

namespace RiRiSharp.Bootstrap.Core.Content.Images;

[Flags]
public enum ImageOptions
{
    None,
    Fluid = 1 << 0,
    Thumbnail = 1 << 1,
    Rounded = 1 << 2,
    Figure = 1 << 3,
}

public static class ImageOptionsExtensions
{
    private static readonly Dictionary<ImageOptions, string> ClassMapping = new()
    {
        { ImageOptions.Fluid, "img-fluid" },
        { ImageOptions.Thumbnail, "img-thumbnail" },
        { ImageOptions.Rounded, "rounded" },
        { ImageOptions.Figure, "figure-img" },
    };

    public static string ToBootstrapClass(this ImageOptions imageOptions)
    {
        return imageOptions.BuildBootstrapClassInner();
    }

    private static string BuildBootstrapClassInner(this ImageOptions tableOptions)
    {
        var returnClass = ClassMapping.Where(kvp => tableOptions.HasFlag(kvp.Key)).Select(kvp => kvp.Value);

        return string.Join(" ", returnClass);
    }
}