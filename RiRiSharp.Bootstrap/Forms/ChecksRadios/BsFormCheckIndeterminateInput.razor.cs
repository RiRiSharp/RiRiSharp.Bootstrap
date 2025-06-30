using Microsoft.AspNetCore.Components;

namespace RiRiSharp.Bootstrap.Forms.ChecksRadios;

public partial class BsFormCheckIndeterminateInput : BsInputBase<bool?>
{
    private readonly CheckboxJsFunctions _checkboxJsFunctions;
    private ElementReference _checkboxReference;

    public BsFormCheckIndeterminateInput(CheckboxJsFunctions checkboxJsFunctions)
    {
        _checkboxJsFunctions = checkboxJsFunctions;
    }
    
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
            await _checkboxJsFunctions.InitializeIndeterminate(_checkboxReference);
    }

    protected override bool TryParseValueFromString(string value, out bool? result, out string validationErrorMessage)
    {
        throw new NotImplementedException("This method is not necessary for parsing input checkboxes.");
    }

    protected override string DetermineClasses()
    {
        return "form-check-input";
    }
}