using Microsoft.AspNetCore.Components.Forms;

namespace RiRiSharp.Bootstrap.Forms.Validation;

public class BsEditContextBuilder
{
    public static EditContext Build(object model)
    {
        var editContext = new EditContext(model);
        editContext.SetFieldCssClassProvider(new BsFieldCssClassProvider());
        return editContext;
    }
}