using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using RiRiSharp.Bootstrap.Internals;

namespace RiRiSharp.Bootstrap.Forms.ChecksRadios;

internal class BsCheckboxJsFunctions : IBsCheckboxJsFunctions, IAsyncDisposable
{
    internal const string JS_FILE_NAME = "BsCheckboxJsFunctions.js";
    private readonly IJSObjectReference _bsJsObjectRef;

    internal BsCheckboxJsFunctions(IJSRuntime jsRuntime)
    {
        _bsJsObjectRef = new BsJsObjectReference(
            jsRuntime,
            $"./_content/{typeof(BsCheckboxJsFunctions).Assembly.GetName().Name}/js/{JS_FILE_NAME}"
        );
    }

    internal BsCheckboxJsFunctions(IJSObjectReference js)
    {
        _bsJsObjectRef = js;
    }

    internal const string INITIALIZE_INDETERMINATE = "initializeIndeterminate";

    public async ValueTask InitializeIndeterminateAsync(ElementReference checkboxReference)
    {
        await _bsJsObjectRef.InvokeVoidAsync(INITIALIZE_INDETERMINATE, checkboxReference);
    }

    public async ValueTask DisposeAsync()
    {
        await _bsJsObjectRef.DisposeAsync();
    }
}
