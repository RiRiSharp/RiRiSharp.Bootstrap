using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.Internals;

namespace RiRiSharp.Bootstrap.Components.Buttons.Internals;

public interface IBsButtonJsFunctions : IBsJsHasDispose
{
    Task ToggleAsync(ElementReference buttonRef);
}
