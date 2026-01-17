using Microsoft.AspNetCore.Components;

namespace Wader.Internals;

public interface IBsJsDisposable
{
    Task DisposeAsync(ElementReference elementRef);
}
