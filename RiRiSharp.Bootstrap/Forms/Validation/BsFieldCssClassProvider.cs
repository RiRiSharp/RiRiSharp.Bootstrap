using Microsoft.AspNetCore.Components.Forms;

namespace RiRiSharp.Bootstrap.Forms.Validation;

public class BsFieldCssClassProvider : FieldCssClassProvider
{
    public override string GetFieldCssClass(EditContext editContext,
        in FieldIdentifier fieldIdentifier)
    {
        var isInvalid = editContext.GetValidationMessages(fieldIdentifier).Any();

        if (isInvalid) 
            return "is-invalid";

        if (editContext.IsModified(fieldIdentifier)) 
            return "is-valid";

        return string.Empty;
    }
}