using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.Internals;

namespace RiRiSharp.Bootstrap.BaseComponents;

public abstract class BsComponent : ComponentBase, IBsComponent
{
    protected abstract string BsComponentClasses { get; }
    public string Classes => BsAttributeUtilities.CombineClassNames(AdditionalAttributes, BsComponentClasses);

    [Parameter(CaptureUnmatchedValues = true)]
    public IReadOnlyDictionary<string, object>? AdditionalAttributes { get; set; }

    public ElementReference HtmlRef { get; protected set; }
}
