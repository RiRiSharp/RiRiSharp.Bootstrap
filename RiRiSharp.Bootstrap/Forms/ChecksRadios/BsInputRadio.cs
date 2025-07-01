using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using RiRiSharp.Bootstrap.Internals;

namespace RiRiSharp.Bootstrap.Forms.ChecksRadios;

public class BsInputRadio<TValue> : InputRadio<TValue>
{
    [Parameter] public BsFormCheckOptions FormCheckOptions { get; set; } = BsFormCheckOptions.Stacked;
    protected override void OnParametersSet()
    {
        base.OnParametersSet();
        SetClasses();
    }

    private void SetClasses()
    {
        var allClasses = DetermineClasses();
        AdditionalAttributes = BsAttributeUtilities.AssignClassNames(AdditionalAttributes, allClasses);
    }

    private string DetermineClasses()
    {
        return "form-check-input";
    }
}