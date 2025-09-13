using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using RiRiSharp.Bootstrap.Internals;

namespace RiRiSharp.Bootstrap.Forms.ChecksRadios;

internal class BsCheckboxJsFunctions : IBsCheckboxJsFunctions, IAsyncDisposable
{
    internal const string JS_FILE_NAME = "BsCheckboxJsFunctions.js";
    private readonly BsJsObjectReference _bsJsObjectRef;

    internal BsCheckboxJsFunctions(IJSRuntime jsRuntime)
    {
        _bsJsObjectRef = new BsJsObjectReference(
            jsRuntime,
            $"./_content/{typeof(BsCheckboxJsFunctions).Assembly.GetName().Name}/js/{JS_FILE_NAME}"
        );
    }

    internal const string INIT_INDETERMINATE_JS_FUNCTION_NAME = "initializeIndeterminate";

    public async ValueTask InitializeIndeterminateAsync(ElementReference checkboxReference)
    {
        await _bsJsObjectRef.InvokeVoidAsync(INIT_INDETERMINATE_JS_FUNCTION_NAME, checkboxReference);
    }

    public async ValueTask DisposeAsync()
    {
        if (_bsJsObjectRef is null)
        {
            return;
        }

        await _bsJsObjectRef.DisposeAsync();
    }
}
