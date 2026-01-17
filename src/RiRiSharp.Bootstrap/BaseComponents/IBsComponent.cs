using Microsoft.AspNetCore.Components;

namespace RiRiSharp.Bootstrap.BaseComponents;

public interface IBsComponent
{
    IReadOnlyDictionary<string, object>? AdditionalAttributes { get; set; }
}
