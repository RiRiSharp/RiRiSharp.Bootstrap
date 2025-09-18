using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using RiRiSharp.Bootstrap.BaseComponents;
using RiRiSharp.Bootstrap.Components.Alert.Internals;

namespace RiRiSharp.Bootstrap.Components.Alert;

public partial class BsAlert : BsChildContentComponent
{
    private DotNetObjectReference<BsAlert>? _dotNetRef;
    private bool _dismissed;
    private BsAlertContext _alertContext = null!;

    public IBsAlertContext AlertContext => _alertContext;

    [Inject]
    private IBsAlertJsFunctions AlertJsFunctions { get; set; } = null!;

    [Parameter]
    public BsAlertVariant Variant { get; set; }

    [Parameter]
    public bool Dismissable { get; set; }

    private string DismissableClass => Dismissable ? "alert-dismissible" : "";

    [Parameter]
    public bool Animate { get; set; } = true;

    private string AnimationClass => Animate ? "fade show" : "";

    [Parameter]
    public RenderFragment? DismissContent { get; set; }

    protected override void OnInitialized()
    {
        base.OnInitialized();
        _alertContext = new BsAlertContext(this);
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            _dotNetRef = DotNetObjectReference.Create(this);
            await AlertJsFunctions.RegisterDismissCallbackAsync(HtmlRef, _dotNetRef);
        }
    }

    public async Task DismissAsync()
    {
        if (!Dismissable)
        {
            throw new InvalidOperationException(
                $"{nameof(BsAlert)} requires {nameof(Dismissable)} to be true in order to dismiss."
            );
        }

        await AlertJsFunctions.DismissAsync(HtmlRef);
    }

    [JSInvokable]
    public void UpdateDismissedState()
    {
        _dismissed = true;
    }
}
