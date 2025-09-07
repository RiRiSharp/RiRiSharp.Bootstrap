namespace RiRiSharp.Bootstrap.Content.Headings;

public enum BsHeadingType
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
    public static string ToBootstrapClass(this BsHeadingType headingType)
    {
        return headingType.ToString().ToLowerInvariant();
    }
}