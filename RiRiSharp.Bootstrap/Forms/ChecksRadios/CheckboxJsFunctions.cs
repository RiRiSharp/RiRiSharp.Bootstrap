using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using RiRiSharp.Bootstrap.Internals;

namespace RiRiSharp.Bootstrap.Forms.ChecksRadios;

public class CheckboxJsFunctions
{
    private readonly BsJsObjectReference _bsJsObjectReference;

    public CheckboxJsFunctions(IJSRuntime jsRuntime)
    {
        _bsJsObjectReference = new BsJsObjectReference(jsRuntime, $"./_content/{typeof(CheckboxJsFunctions).Assembly.GetName().Name}/js/checkboxFunctions.js");
    }

    public async ValueTask InitializeIndeterminate(ElementReference checkboxReference)
    {
        await _bsJsObjectReference.InvokeVoidAsync("initializeIndeterminate", checkboxReference);
    }
}