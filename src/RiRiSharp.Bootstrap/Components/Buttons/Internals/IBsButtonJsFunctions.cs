using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.Internals;

namespace RiRiSharp.Bootstrap.Components.Buttons.Internals;

public interface IBsButtonJsFunctions : IBsJsDisposable
{
    Task ToggleAsync(ElementReference buttonRef);
}
