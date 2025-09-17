using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using RiRiSharp.Bootstrap.Components.Accordion;
using RiRiSharp.Bootstrap.Internals;

namespace RiRiSharp.Bootstrap.Components.Alert;

internal sealed class BsAlertJsFunctions : IBsAlertJsFunctions, IAsyncDisposable
{
    internal const string JS_FILE_NAME = "alertFunctions.js";
    private readonly BsJsObjectReference _bsJsObjectRef;

    public BsAlertJsFunctions(IJSRuntime jsRuntime)
    {
        _bsJsObjectRef = new BsJsObjectReference(
            jsRuntime,
            $"./_content/{typeof(BsAccordionJsFunctions).Assembly.GetName().Name}/js/{JS_FILE_NAME}"
        );
    }

    internal const string DISMISS = "dismiss";

    public async Task DismissAsync(ElementReference alertRef)
    {
        await _bsJsObjectRef.InvokeVoidAsync(DISMISS, alertRef);
    }

    internal const string REGISTER_DISMISS_CALLBACK = "registerDismissCallback";

    public async Task RegisterDismissCallbackAsync(ElementReference alertRef, DotNetObjectReference<BsAlert> dotNetRef)
    {
        await _bsJsObjectRef.InvokeVoidAsync(REGISTER_DISMISS_CALLBACK, alertRef, dotNetRef);
    }

    public async ValueTask DisposeAsync()
    {
        await _bsJsObjectRef.DisposeAsync();
    }
}
