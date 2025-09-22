using Microsoft.AspNetCore.Components;

namespace RiRiSharp.Bootstrap.Internals;

public interface IBsJsHasDispose
{
    Task DisposeAsync(ElementReference elementRef);
}
