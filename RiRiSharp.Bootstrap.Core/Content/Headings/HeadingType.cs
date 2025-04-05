namespace RiRiSharp.Bootstrap.Core.Content.Headings;

public enum HeadingType
{
    H1,
    H2,
    H3,
    H4,
    H5,
    H6
}

public static class HeadingTypeExtensions
{
    public static string ToBootstrapClass(this HeadingType headingType)
    {
        return headingType.ToString().ToLowerInvariant();
    }
}