using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using RiRiSharp.Bootstrap.BaseComponents;
using RiRiSharp.Bootstrap.Internals;

namespace RiRiSharp.Bootstrap.Forms.Validation;

public class BsValidationMessage<TValue> : ValidationMessage<TValue>, IBsComponent
{
    [Parameter]
    public string Classes { get; set; }
    public ElementReference HtmlRef => default; // TODO https://github.com/RiRiSharp/RiRiSharp.Bootstrap/issues/5

    protected override void OnParametersSet()
    {
        base.OnParametersSet();
        SetClasses();
    }

    private void SetClasses()
    {
        var componentSpecificClasses = GetBsComponentSpecificClasses();
        var allClasses = $"{componentSpecificClasses} {Classes}";
        AdditionalAttributes = BsAttributeUtilities.AssignClassNames(
            AdditionalAttributes,
            allClasses
        );
    }

    private string GetBsComponentSpecificClasses()
    {
        return "invalid-feedback";
    }
}
