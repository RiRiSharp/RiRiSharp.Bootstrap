namespace RiRiSharp.Bootstrap.Components.Accordion.Internals;

public class BsAccordionItemContext(BsAccordionItem accordionItem)
{
    public async Task ToggleAsync()
    {
        await accordionItem.ToggleAsync();
    }
}