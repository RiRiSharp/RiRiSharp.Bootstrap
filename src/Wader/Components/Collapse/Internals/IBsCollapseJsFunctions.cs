using Microsoft.AspNetCore.Components;
using Wader.Internals;

namespace Wader.Components.Collapse.Internals;

public interface IBsCollapseJsFunctions : IBsJsDisposable
{
    Task CollapseAsync(ElementReference collapseRef);
    Task ShowAsync(ElementReference collapseRef);
    Task ToggleAsync(ElementReference collapseRef);
}
