using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Wader.Internals;

namespace Wader.Components.Offcanvas.Internals;

internal sealed class BsOffcanvasJsFunctions : IBsOffcanvasJsFunctions, IBsJsFunctionsWrapper, IAsyncDisposable
{
    public static string JsFileName => "modalFunctions.js";
    private readonly IJSObjectReference _bsJsObjectRef;

    public BsOffcanvasJsFunctions(IJSObjectReference bsJsObjectRef)
    {
        _bsJsObjectRef = bsJsObjectRef;
    }

    internal const string TOGGLE = "toggle";

    public async Task ToggleAsync(ElementReference offcanvasRef)
    {
        await _bsJsObjectRef.InvokeVoidAsync(TOGGLE, offcanvasRef);
    }

    internal const string SHOW = "show";

    public async Task ShowAsync(ElementReference offcanvasRef)
    {
        await _bsJsObjectRef.InvokeVoidAsync(SHOW, offcanvasRef);
    }

    internal const string CLOSE = "close";

    public async Task CloseAsync(ElementReference offcanvasRef)
    {
        await _bsJsObjectRef.InvokeVoidAsync(CLOSE, offcanvasRef);
    }

    internal const string DISPOSE = "dispose";

    public async Task DisposeAsync(ElementReference elementRef)
    {
        await _bsJsObjectRef.InvokeVoidAsync(DISPOSE, elementRef);
    }

    public async ValueTask DisposeAsync()
    {
        await _bsJsObjectRef.DisposeAsync();
    }
}
