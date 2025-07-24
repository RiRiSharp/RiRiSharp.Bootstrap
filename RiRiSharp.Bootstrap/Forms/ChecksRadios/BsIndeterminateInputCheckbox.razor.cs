using Microsoft.AspNetCore.Components;

namespace RiRiSharp.Bootstrap.Forms.ChecksRadios;

public partial class BsIndeterminateInputCheckbox : BsInputBase<bool?>
{
    private readonly BsCheckboxJsFunctions _bsCheckboxJsFunctions;
    private ElementReference _checkboxReference;

    public BsIndeterminateInputCheckbox(BsCheckboxJsFunctions bsCheckboxJsFunctions)
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

    protected override string GetBsComponentSpecificClasses()
    {
        return "form-check-input";
    }
}