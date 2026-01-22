using Microsoft.AspNetCore.Components;
using Wader.BaseComponents;
using Wader.Components.Offcanvas.Internals;
using Wader.Primitives;

namespace Wader.Components.Offcanvas;

public partial class BsOffcanvas : BsChildContentComponent, IAsyncDisposable
{
    internal ElementReference HtmlRef;
    protected override string BsComponentClasses => $"offcanvas {DirectionClass}";
    public IBsOffcanvasContext? OffcanvasContext { get; private set; }

    [Parameter]
    public BsDirection Direction { get; set; } = BsDirection.Start;

    [Parameter]
    public bool EnableScroll { get; set; }

    private string DataBsScroll => EnableScroll.ToString().ToLowerInvariant();

    [Parameter]
    public BsBackdrop Backdrop { get; set; }

    private string? DataBsBackdrop => Backdrop.ToDataBsBackdropValue();

    [Inject]
    public IBsOffcanvasJsFunctions BsOffcanvasJsFunctions { get; set; } = null!;

    private string DirectionClass => Direction.ToOffcanvasBootstrapClass();

    public async ValueTask DisposeAsync()
    {
        await Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected override void OnInitialized()
    {
        base.OnInitialized();
        OffcanvasContext = new BsOffcanvasContext(this);
    }

    public async Task ToggleAsync()
    {
        await BsOffcanvasJsFunctions.ToggleAsync(HtmlRef);
    }

    public async Task ShowAsync()
    {
        await BsOffcanvasJsFunctions.ShowAsync(HtmlRef);
    }

    public async Task CloseAsync()
    {
        await BsOffcanvasJsFunctions.CloseAsync(HtmlRef);
    }

    private async Task Dispose(bool disposing)
    {
        if (!disposing)
        {
            return;
        }

        await BsOffcanvasJsFunctions.DisposeAsync(HtmlRef);
    }
}
