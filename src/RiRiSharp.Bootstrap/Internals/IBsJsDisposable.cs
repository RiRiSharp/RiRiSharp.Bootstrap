using Microsoft.AspNetCore.Components;

namespace RiRiSharp.Bootstrap.Internals;

public interface IBsJsDisposable
{
    Task DisposeAsync(ElementReference elementRef);
}
