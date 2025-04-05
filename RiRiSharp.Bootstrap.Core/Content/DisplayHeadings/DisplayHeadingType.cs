namespace RiRiSharp.Bootstrap.Core.Content.DisplayHeadings;

public enum DisplayHeadingType
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
    public static string ToBootstrapClass(this DisplayHeadingType displayHeadingType)
    {
        return displayHeadingType switch
        {
            DisplayHeadingType.Display1 => "display-1",
            DisplayHeadingType.Display2 => "display-2",
            DisplayHeadingType.Display3 => "display-3",
            DisplayHeadingType.Display4 => "display-4",
            DisplayHeadingType.Display5 => "display-5",
            DisplayHeadingType.Display6 => "display-6",
            _ => throw new ArgumentOutOfRangeException(nameof(displayHeadingType), displayHeadingType, null)
        };
    }
}