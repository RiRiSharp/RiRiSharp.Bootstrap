using Microsoft.AspNetCore.Components;

namespace RiRiSharp.Bootstrap.Forms.ChecksRadios;

public interface IBsCheckboxJsFunctions
{
    ValueTask InitializeIndeterminate(ElementReference checkboxReference);
}