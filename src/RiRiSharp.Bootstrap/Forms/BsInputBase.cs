using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using RiRiSharp.Bootstrap.BaseComponents;
using RiRiSharp.Bootstrap.Internals;

namespace RiRiSharp.Bootstrap.Forms;

public abstract class BsInputBase<TValue> : InputBase<TValue>, IBsComponent
{
    [Parameter] public string Classes { get; set; }
    protected ElementReference htmlRef;
    public ElementReference HtmlRef => htmlRef;

    protected override void OnParametersSet()
    {
        base.OnParametersSet();
        SetClasses();
    }

    private void SetClasses()
    {
        var componentSpecificClasses = GetBsComponentSpecificClasses();
        var allClasses = $"{componentSpecificClasses} {Classes}";
        AdditionalAttributes = BsAttributeUtilities.AssignClassNames(AdditionalAttributes, allClasses);
    }

    protected abstract string GetBsComponentSpecificClasses();
}