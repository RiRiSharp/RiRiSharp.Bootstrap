using RiRiSharp.Bootstrap.Internals;

namespace RiRiSharp.Bootstrap.Components.Accordion.Internals;

internal record AccordionItemIdentifier
{
    internal AccordionItemIdentifier()
    {
        Id = BsIdGenerator.Generate();
    }

    internal AccordionItemIdentifier(string id)
    {
        Id = id;
    }
    
    public string Id { get; }
}

