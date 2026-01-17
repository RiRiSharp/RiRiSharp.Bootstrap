namespace Wader.Components.Accordion;

public enum BsAccordionDisplayStyle
{
    Regular = 0,
    Flush = 1,
}

public static class BsAccordionDisplayStyleExtensions
{
    public static string ToBootstrapClass(this BsAccordionDisplayStyle style)
    {
        return style switch
        {
            BsAccordionDisplayStyle.Regular => "",
            BsAccordionDisplayStyle.Flush => "accordion-flush",
            _ => throw new ArgumentOutOfRangeException(nameof(style), style, null),
        };
    }
}
