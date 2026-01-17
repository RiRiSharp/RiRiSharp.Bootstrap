using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.BaseComponents;
using RiRiSharp.Bootstrap.Components.Collapse.Internals;
using RiRiSharp.Bootstrap.Internals.Exceptions;

namespace RiRiSharp.Bootstrap.Components.Collapse;

public partial class BsCollapse : BsChildContentComponent, IAsyncDisposable
{
    internal ElementReference HtmlRef;
    protected override string BsComponentClasses => $"collapse {ShowClass} {DirectionClass}";

    [Parameter]
    public BsCollapseDirection Direction { get; set; }

    [Parameter]
    public bool Show { get; set; }

    private string ShowClass => Show ? "show" : "";

    [Inject]
    private IBsCollapseJsFunctions? CollapseJsFunctions { get; set; }

    private string DirectionClass => Direction.ToBootstrapClass();

    public async ValueTask DisposeAsync()
    {
        await Dispose(true);
        GC.SuppressFinalize(this);
    }

    public async Task ToggleAsync()
    {
        BsJsInteractionNotEnabledException.ThrowIfNull(CollapseJsFunctions, nameof(CollapseJsFunctions.ToggleAsync));
        await CollapseJsFunctions.ToggleAsync(HtmlRef);
    }

    public async Task ShowAsync()
    {
        BsJsInteractionNotEnabledException.ThrowIfNull(CollapseJsFunctions, nameof(CollapseJsFunctions.ShowAsync));
        await CollapseJsFunctions.ShowAsync(HtmlRef);
    }

    public async Task CollapseAsync()
    {
        BsJsInteractionNotEnabledException.ThrowIfNull(CollapseJsFunctions, nameof(CollapseJsFunctions.CollapseAsync));
        await CollapseJsFunctions.CollapseAsync(HtmlRef);
    }

    private async Task Dispose(bool disposing)
    {
        if (!disposing || CollapseJsFunctions is null)
        {
            return;
        }

        await CollapseJsFunctions.DisposeAsync(HtmlRef);
    }
}
