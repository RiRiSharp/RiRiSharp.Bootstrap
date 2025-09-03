using RiRiSharp.Bootstrap.Internals;

namespace RiRiSharp.Bootstrap.Components.Accordion.Internals;

public sealed class BsAccordionContext : IBsAccordionContext
{
    private readonly AsyncFuncRegistry<BsAccordionItem> _onShow = new();
    private readonly AsyncFuncRegistry<BsAccordionItem> _onCollapse = new();

    internal IAsyncFuncRegistry<BsAccordionItem> OnShow => _onShow;
    internal IAsyncFuncRegistry<BsAccordionItem> OnCollapse => _onCollapse;

    internal async Task ShowItemAsync(BsAccordionItem item)
    {
        await _onShow.Execute(item);
    }
    
    internal async Task ShowAllItemAsync()
    {
        await _onShow.ExecuteAll();
    }

    internal async Task CollapseItemAsync(BsAccordionItem item)
    {
        await _onCollapse.Execute(item);
    }
    
    internal async Task CollapseAllItemsAsync()
    {
        await _onCollapse.ExecuteAll();
    }

}

public interface IBsAccordionContext
{
}