namespace RiRiSharp.Bootstrap.Components.Accordion.Internals;

internal class BsAccordionContext
{
    private readonly HashSet<BsAccordionItem> _items = [];
    internal IEnumerable<BsAccordionItem> Items => _items;
    
    internal void AddItem(BsAccordionItem item)
    {
        _items.Add(item);
    }
    
    internal void RemoveItem(BsAccordionItem item)
    {
        _items.Remove(item);
    }
}