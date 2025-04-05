namespace RiRiSharp.Bootstrap.Core.Content.Images;

[Flags]
public enum ImageOptions
{
    None,
    Fluid = 1 << 0,
    Thumbnail = 1 << 1,
    Rounded = 1 << 2,
}

public static class ImageOptionsExtensions
{
    public static string ToBootstrapClass(this ImageOptions imageOptions)
    {
        var classes = string.Empty;
        if (imageOptions == ImageOptions.None) return classes;
        
        if(imageOptions.HasFlag(ImageOptions.Fluid)) classes += " img-fluid";
        if(imageOptions.HasFlag(ImageOptions.Thumbnail)) classes += " img-thumbnail";
        if(imageOptions.HasFlag(ImageOptions.Rounded)) classes += " rounded";

        return classes;
    }
}