using RiRiSharp.Bootstrap.Internals;

namespace RiRiSharp.Bootstrap.Components.Accordion.Internals;

public sealed class BsAccordionContext : IBsAccordionContext
{
    public bool AlwaysOpen { get; set; }
}

public interface IBsAccordionContext
{
    bool AlwaysOpen { get; }
}