namespace RiRiSharp.Bootstrap.Components.Accordion.Internals;

public class BsAccordionItemContext(BsAccordionItem accordionItem)
{
    public bool Collapsed => accordionItem.InitialCollapsed;

    public async Task ToggleAsync()
    {
        await accordionItem.ToggleAsync();
    }
}
