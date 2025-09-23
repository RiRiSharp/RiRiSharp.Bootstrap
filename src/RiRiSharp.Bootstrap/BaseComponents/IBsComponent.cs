using Microsoft.AspNetCore.Components;

namespace RiRiSharp.Bootstrap.BaseComponents;

public interface IBsComponent
{
    string? Classes { get; }
    IReadOnlyDictionary<string, object>? AdditionalAttributes { get; set; }
    ElementReference HtmlRef { get; }
}
