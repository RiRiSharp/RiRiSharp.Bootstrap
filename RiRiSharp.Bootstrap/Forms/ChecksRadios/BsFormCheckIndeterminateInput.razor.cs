using Microsoft.AspNetCore.Components;

namespace RiRiSharp.Bootstrap.Forms.ChecksRadios;

public partial class BsFormCheckIndeterminateInput : BsInputBase<bool?>
{
    private readonly BsCheckboxJsFunctions _bsCheckboxJsFunctions;
    private ElementReference _checkboxReference;

    public BsFormCheckIndeterminateInput(BsCheckboxJsFunctions bsCheckboxJsFunctions)
    {
        _bsCheckboxJsFunctions = bsCheckboxJsFunctions;
    }
    
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
            await _bsCheckboxJsFunctions.InitializeIndeterminate(_checkboxReference);
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