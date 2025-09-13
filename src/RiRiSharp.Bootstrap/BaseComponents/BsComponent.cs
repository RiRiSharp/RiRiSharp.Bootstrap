using Microsoft.AspNetCore.Components;

namespace RiRiSharp.Bootstrap.BaseComponents;

public class BsComponent : ComponentBase, IBsComponent
{
    [Parameter]
    public string? Classes { get; set; }

    [Parameter(CaptureUnmatchedValues = true)]
    public IReadOnlyDictionary<string, object>? AdditionalAttributes { get; set; }

    public ElementReference HtmlRef { get; protected set; }
}
