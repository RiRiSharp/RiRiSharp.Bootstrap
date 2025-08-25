using Microsoft.AspNetCore.Components.Forms;

namespace RiRiSharp.Bootstrap.Forms.Validation;

public class BsFieldCssClassProvider(bool showValidInput = true) : FieldCssClassProvider
{
    public override string GetFieldCssClass(EditContext editContext,
        in FieldIdentifier fieldIdentifier)
    {
        var isInvalid = editContext.GetValidationMessages(fieldIdentifier).Any();
        
        return DetermineClass(editContext.IsModified(fieldIdentifier), isInvalid);
    }

    internal string DetermineClass(bool isModified, bool isInvalid)
    {
        if (!isModified) return "";
        if (isInvalid) return "is-invalid";
        if (showValidInput) return "is-valid";
        return "";
    }
}