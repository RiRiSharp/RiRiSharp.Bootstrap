using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using RiRiSharp.Bootstrap.BaseComponents;
using RiRiSharp.Bootstrap.Internals;

namespace RiRiSharp.Bootstrap.Forms;

public abstract class BsInputBase<TValue> : InputBase<TValue>, IBsComponent
{
    protected abstract string BsComponentClasses { get; }

    private Dictionary<string, object>? _renderAttributes;

    protected IReadOnlyDictionary<string, object>? RenderAttributes => _renderAttributes;

    protected override void OnParametersSet()
    {
        base.OnParametersSet();
        _renderAttributes = BsAttributeUtilities.AssignClassNames(AdditionalAttributes, BsComponentClasses);

        var errorSuccessClass = EditContext?.FieldCssClass(FieldIdentifier);
        _renderAttributes = BsAttributeUtilities.AssignClassNames(RenderAttributes, errorSuccessClass);
    }
}
