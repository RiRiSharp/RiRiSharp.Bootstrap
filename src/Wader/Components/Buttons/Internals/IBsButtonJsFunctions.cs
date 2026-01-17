using Microsoft.AspNetCore.Components;
using Wader.Internals;

namespace Wader.Components.Buttons.Internals;

public interface IBsButtonJsFunctions : IBsJsDisposable
{
    Task ToggleAsync(ElementReference buttonRef);
}
