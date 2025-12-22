using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.Internals;

namespace RiRiSharp.Bootstrap.BaseComponents;

public abstract class BsComponent : ComponentBase, IBsComponent
{
    protected abstract string BsComponentClasses { get; }

    [Parameter(CaptureUnmatchedValues = true)]
    public IReadOnlyDictionary<string, object>? AdditionalAttributes { get; set; }

    public virtual ElementReference HtmlRef { get; protected set; }

    private Dictionary<string, object>? _renderAttributes;

    protected IReadOnlyDictionary<string, object>? RenderAttributes => _renderAttributes;

    protected override void OnParametersSet()
    {
        base.OnParametersSet();
        _renderAttributes = BsAttributeUtilities.AssignClassNames(AdditionalAttributes, BsComponentClasses);
    }
}
