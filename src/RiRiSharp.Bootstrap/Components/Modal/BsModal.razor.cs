using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.BaseComponents;
using RiRiSharp.Bootstrap.Components.Modal.Internals;

namespace RiRiSharp.Bootstrap.Components.Modal;

public partial class BsModal : BsChildContentComponent, IAsyncDisposable
{
    protected override string BsComponentClasses => $"modal {FadeClass}";

    public IBsModalContext? ModalContext { get; private set; }

    [Parameter]
    public BsModalBackdrop Backdrop { get; set; }

    private string? DataBsBackdrop => Backdrop == BsModalBackdrop.Static ? "static" : null;
    private string? DataBsKeyboard => Backdrop == BsModalBackdrop.Static ? "false" : null;

    [Parameter]
    public bool FadeEnabled { get; set; } = true;
    private string FadeClass => FadeEnabled ? "fade" : "";

    [Inject]
    private IBsModalJsFunctions BsModalJsFunctions { get; set; } = null!;

    protected override void OnInitialized()
    {
        base.OnInitialized();
        ModalContext = new BsModalContext(this);
    }

    public async Task ToggleAsync()
    {
        await BsModalJsFunctions.ToggleAsync(HtmlRef);
    }

    public async Task ShowAsync()
    {
        await BsModalJsFunctions.ShowAsync(HtmlRef);
    }

    public async Task CloseAsync()
    {
        await BsModalJsFunctions.CloseAsync(HtmlRef);
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

        await BsModalJsFunctions.DisposeAsync(HtmlRef);
    }
}
