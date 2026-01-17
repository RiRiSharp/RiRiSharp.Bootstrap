using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.BaseComponents;
using RiRiSharp.Bootstrap.Components.Modal.Internals;
using RiRiSharp.Bootstrap.Internals.Exceptions;

namespace RiRiSharp.Bootstrap.Components.Modal;

public partial class BsModal : BsChildContentComponent, IAsyncDisposable
{
    internal ElementReference HtmlRef;
    protected override string BsComponentClasses => $"modal {FadeClass}";

    public IBsModalContext? ModalContext { get; private set; }

    [Parameter]
    public BsModalBackdrop Backdrop { get; set; }

    private string? DataBsBackdrop => Backdrop == BsModalBackdrop.Static ? "static" : null;
    private string? DataBsKeyboard => Backdrop == BsModalBackdrop.Static ? "false" : null;

    [Parameter]
    public bool Fade { get; set; } = true;
    private string FadeClass => Fade ? "fade" : "";

    [Inject]
    private IBsModalJsFunctions? BsModalJsFunctions { get; set; }

    protected override void OnInitialized()
    {
        base.OnInitialized();
        ModalContext = new BsModalContext(this);
    }

    public async Task ToggleAsync()
    {
        BsJsInteractionNotEnabledException.ThrowIfNull(BsModalJsFunctions, nameof(BsModalJsFunctions.ToggleAsync));
        await BsModalJsFunctions.ToggleAsync(HtmlRef);
    }

    public async Task ShowAsync()
    {
        BsJsInteractionNotEnabledException.ThrowIfNull(BsModalJsFunctions, nameof(BsModalJsFunctions.ShowAsync));
        await BsModalJsFunctions.ShowAsync(HtmlRef);
    }

    public async Task CloseAsync()
    {
        BsJsInteractionNotEnabledException.ThrowIfNull(BsModalJsFunctions, nameof(BsModalJsFunctions.CloseAsync));
        await BsModalJsFunctions.CloseAsync(HtmlRef);
    }

    public async ValueTask DisposeAsync()
    {
        await Dispose(true);
        GC.SuppressFinalize(this);
    }

    private async Task Dispose(bool disposing)
    {
        if (!disposing || BsModalJsFunctions is null)
        {
            return;
        }

        await BsModalJsFunctions.DisposeAsync(HtmlRef);
    }
}
