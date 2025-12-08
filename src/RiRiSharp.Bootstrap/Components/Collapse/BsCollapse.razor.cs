using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.BaseComponents;
using RiRiSharp.Bootstrap.Components.Collapse.Internals;

namespace RiRiSharp.Bootstrap.Components.Collapse;

public partial class BsCollapse : BsChildContentComponent, IAsyncDisposable
{
    protected override string BsComponentClasses => $"collapse {DirectionClass}";

    [Parameter]
    public BsCollapseDirection Direction { get; set; }

    [Inject]
    private IBsCollapseJsFunctions CollapseJsFunctions { get; set; } = null!;

    private string DirectionClass => Direction.ToBootstrapClass();

    public async Task CollapseAsync()
    {
        await CollapseJsFunctions.CollapseAsync(HtmlRef);
    }

    public async Task ExpandAsync()
    {
        await CollapseJsFunctions.ExpandAsync(HtmlRef);
    }

    public async Task ToggleAsync()
    {
        await CollapseJsFunctions.ToggleAsync(HtmlRef);
    }

    public async ValueTask DisposeAsync()
    {
        await Dispose(true);
        GC.SuppressFinalize(this);
    }

    private async Task Dispose(bool disposing)
    {
        if (!disposing)
        {
            return;
        }

        await CollapseJsFunctions.DisposeAsync(HtmlRef);
    }
}
