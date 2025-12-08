using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.Internals;

namespace RiRiSharp.Bootstrap.Components.Collapse.Internals;

public interface IBsCollapseJsFunctions : IBsJsDisposable
{
    Task CollapseAsync(ElementReference collapseRef);
    Task ExpandAsync(ElementReference collapseRef);
    Task ToggleAsync(ElementReference collapseRef);
}
