using Microsoft.AspNetCore.Components;

namespace Wader.BaseComponents;

public interface IBsComponent
{
    IReadOnlyDictionary<string, object>? AdditionalAttributes { get; set; }
}
