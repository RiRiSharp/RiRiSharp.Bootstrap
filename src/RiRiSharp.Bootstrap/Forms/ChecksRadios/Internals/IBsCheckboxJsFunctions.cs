using Microsoft.AspNetCore.Components;

namespace RiRiSharp.Bootstrap.Forms.ChecksRadios.Internals;

public interface IBsCheckboxJsFunctions
{
    ValueTask InitializeIndeterminateAsync(ElementReference checkboxReference);
}
