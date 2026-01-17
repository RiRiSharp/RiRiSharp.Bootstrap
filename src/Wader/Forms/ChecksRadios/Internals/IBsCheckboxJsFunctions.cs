using Microsoft.AspNetCore.Components;

namespace Wader.Forms.ChecksRadios.Internals;

public interface IBsCheckboxJsFunctions
{
    ValueTask InitializeIndeterminateAsync(ElementReference checkboxReference);
}
