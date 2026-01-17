using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using RiRiSharp.Bootstrap.BaseComponents;
using RiRiSharp.Bootstrap.Components.Alert.Internals;
using RiRiSharp.Bootstrap.Internals.Exceptions;

namespace RiRiSharp.Bootstrap.Components.Alert;

public partial class BsAlert : BsChildContentComponent, IAsyncDisposable
{
    internal ElementReference HtmlRef;
    private DotNetObjectReference<BsAlert>? _dotNetRef;
    private bool _dismissed;
    private BsAlertContext _alertContext = null!;

    protected override string BsComponentClasses =>
        $"alert {Variant.ToBootstrapClass()} {DismissableClass} {AnimationClass}";
    private string DismissableClass => Dismissable ? "alert-dismissible" : "";
    private string AnimationClass => Animate ? "fade show" : "";

    public IBsAlertContext AlertContext => _alertContext;

    [Inject]
    private IBsAlertJsFunctions? AlertJsFunctions { get; set; }

    [Parameter]
    public BsAlertVariant Variant { get; set; }

    [Parameter]
    public bool Dismissable { get; set; }

    [Parameter]
    public bool Animate { get; set; } = true;

    protected override void OnInitialized()
    {
        base.OnInitialized();
        _alertContext = new BsAlertContext(this);
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (!firstRender || AlertJsFunctions is null)
        {
            return;
        }

        _dotNetRef = DotNetObjectReference.Create(this);
        await AlertJsFunctions.RegisterDismissCallbackAsync(HtmlRef, _dotNetRef);
    }

    public async Task DismissAsync()
    {
        if (!Dismissable)
        {
            throw new InvalidOperationException(
                $"{nameof(BsAlert)} requires {nameof(Dismissable)} to be true in order to dismiss."
            );
        }

        BsJsInteractionNotEnabledException.ThrowIfNull(AlertJsFunctions, nameof(AlertJsFunctions.DismissAsync));
        await AlertJsFunctions.DismissAsync(HtmlRef);
    }

    [JSInvokable]
    public void UpdateDismissedState()
    {
        _dismissed = true;
    }

    public async ValueTask DisposeAsync()
    {
        await DisposeAsync(true);
        GC.SuppressFinalize(this);
    }

    private async ValueTask DisposeAsync(bool disposing)
    {
        if (!disposing || AlertJsFunctions is null)
        {
            return;
        }

        await AlertJsFunctions.DisposeAsync(HtmlRef);
        _dotNetRef?.Dispose();
    }
}
