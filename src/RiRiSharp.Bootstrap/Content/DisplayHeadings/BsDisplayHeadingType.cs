namespace RiRiSharp.Bootstrap.Content.DisplayHeadings;

public enum BsDisplayHeadingType
{
    Display1,
    Display2,
    Display3,
    Display4,
    Display5,
    Display6,
}

public static class DisplayHeadingTypeExtensions
{
    public static string ToBootstrapClass(this BsDisplayHeadingType displayHeadingType)
    {
        return displayHeadingType switch
        {
            BsDisplayHeadingType.Display1 => "display-1",
            BsDisplayHeadingType.Display2 => "display-2",
            BsDisplayHeadingType.Display3 => "display-3",
            BsDisplayHeadingType.Display4 => "display-4",
            BsDisplayHeadingType.Display5 => "display-5",
            BsDisplayHeadingType.Display6 => "display-6",
            _ => throw new ArgumentOutOfRangeException(
                nameof(displayHeadingType),
                displayHeadingType,
                null
            ),
        };
    }
}
