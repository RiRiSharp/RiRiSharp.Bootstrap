namespace RiRiSharp.Bootstrap.Components.Accordion;

public enum BsAccordionDisplayStyle
{
    Regular,
    Flush,
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
