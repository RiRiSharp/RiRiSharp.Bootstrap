namespace RiRiSharp.Bootstrap.Components.Accordion.Internals;

public interface IBsAccordionItemContext
{
    bool Collapsed { get; }
    Task ToggleAsync();
}
