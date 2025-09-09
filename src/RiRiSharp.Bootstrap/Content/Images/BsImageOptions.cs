using System.Text;

namespace RiRiSharp.Bootstrap.Content.Images;

[Flags]
public enum BsImageOptions
{
    None,
    Fluid = 1 << 0,
    Thumbnail = 1 << 1,
    Rounded = 1 << 2,
    Figure = 1 << 3,
}

public static class ImageOptionsExtensions
{
    private static readonly Dictionary<BsImageOptions, string> ClassMapping = new()
    {
        { BsImageOptions.Fluid, "img-fluid" },
        { BsImageOptions.Thumbnail, "img-thumbnail" },
        { BsImageOptions.Rounded, "rounded" },
        { BsImageOptions.Figure, "figure-img" },
    };

    public static string ToBootstrapClass(this BsImageOptions imageOptions)
    {
        return imageOptions.BuildBootstrapClassInner();
    }

    private static string BuildBootstrapClassInner(this BsImageOptions tableOptions)
    {
        var returnClass = ClassMapping
            .Where(kvp => tableOptions.HasFlag(kvp.Key))
            .Select(kvp => kvp.Value);

        return string.Join(" ", returnClass);
    }
}
