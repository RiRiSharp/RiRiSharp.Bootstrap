using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using RiRiSharp.Bootstrap.Internals;

namespace RiRiSharp.Bootstrap.Forms.ChecksRadios;

internal class BsCheckboxJsFunctions : IBsCheckboxJsFunctions
{
    private readonly BsJsObjectReference _bsJsObjectReference;

    public BsCheckboxJsFunctions(IJSRuntime jsRuntime)
    {
        _bsJsObjectReference = new BsJsObjectReference(jsRuntime, $"./_content/{typeof(BsCheckboxJsFunctions).Assembly.GetName().Name}/js/checkboxFunctions.js");
    }

    public async ValueTask InitializeIndeterminate(ElementReference checkboxReference)
    {
        await _bsJsObjectReference.InvokeVoidAsync("initializeIndeterminate", checkboxReference);
    }
}