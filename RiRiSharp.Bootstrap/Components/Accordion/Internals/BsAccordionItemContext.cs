namespace RiRiSharp.Bootstrap.Components.Accordion.Internals;

public class BsAccordionItemContext
{
    public async Task Show()
    {
        await OnShow();
    }

    public async Task Collapse()
    {
        await OnCollapse();
    }

    public Func<Task> OnShow { get; set; }
    public Func<Task> OnCollapse { get; set; }
}