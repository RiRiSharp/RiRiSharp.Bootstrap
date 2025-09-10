using Microsoft.AspNetCore.Components;

namespace RiRiSharp.Bootstrap.BaseComponents;

public interface IBsComponent
{
    string Classes { get; set; }
    IReadOnlyDictionary<string, object> AdditionalAttributes { get; set; }
    ElementReference HtmlRef { get; }
}
