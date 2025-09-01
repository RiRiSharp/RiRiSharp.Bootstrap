using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using RiRiSharp.Bootstrap.Internals;

namespace RiRiSharp.Bootstrap.Forms.ChecksRadios;

internal class BsCheckboxJsFunctions : IBsCheckboxJsFunctions
{
    internal const string JsFileName = "BsCheckboxJsFunctions.js";
    private readonly BsJsObjectReference _bsJsObjectReference;

    internal BsCheckboxJsFunctions(IJSRuntime jsRuntime)
    {
        _bsJsObjectReference = new BsJsObjectReference(jsRuntime, $"./_content/{typeof(BsCheckboxJsFunctions).Assembly.GetName().Name}/js/{JsFileName}");
    }

    internal const string InitIndeterminateJsFunctionName = "initializeIndeterminate";
    public async ValueTask InitializeIndeterminateAsync(ElementReference checkboxReference)
    {
        await _bsJsObjectReference.InvokeVoidAsync(InitIndeterminateJsFunctionName, checkboxReference);
    }
}