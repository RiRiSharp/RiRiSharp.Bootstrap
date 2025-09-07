using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using RiRiSharp.Bootstrap.BaseComponents;
using RiRiSharp.Bootstrap.Internals;

namespace RiRiSharp.Bootstrap.Forms;

public class BsEditForm : EditForm, IBsComponent
{
    [Parameter] public string Classes { get; set; }
    protected override void OnParametersSet()
    {
        base.OnParametersSet();
        SetClasses();
    }

    private void SetClasses()
    {
        AdditionalAttributes = BsAttributeUtilities.AssignClassNames(AdditionalAttributes, Classes);
    }
}