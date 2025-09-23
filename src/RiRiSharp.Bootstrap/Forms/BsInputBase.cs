using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using RiRiSharp.Bootstrap.BaseComponents;
using RiRiSharp.Bootstrap.Internals;

namespace RiRiSharp.Bootstrap.Forms;

public abstract class BsInputBase<TValue> : InputBase<TValue>, IBsComponent
{
    protected abstract string BsComponentClasses { get; }
    public string? Classes => CssClass;

    public ElementReference HtmlRef { get; protected set; }

    protected override void OnParametersSet()
    {
        base.OnParametersSet();
        AdditionalAttributes = BsAttributeUtilities.AssignClassNames(AdditionalAttributes, BsComponentClasses);
    }
}
