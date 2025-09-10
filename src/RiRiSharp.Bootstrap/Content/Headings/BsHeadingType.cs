namespace RiRiSharp.Bootstrap.Content.Headings;

public enum BsHeadingType
{
    H1 = 0,
    H2 = 1,
    H3 = 2,
    H4 = 3,
    H5 = 4,
    H6 = 5,
}

public static class HeadingTypeExtensions
{
    public static string ToBootstrapClass(this BsHeadingType headingType)
    {
        return headingType.ToString().ToLowerInvariant();
    }
}
