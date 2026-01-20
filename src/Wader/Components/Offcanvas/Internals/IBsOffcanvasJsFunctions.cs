using Microsoft.AspNetCore.Components;
using Wader.Internals;

namespace Wader.Components.Offcanvas.Internals;

public interface IBsOffcanvasJsFunctions : IBsJsDisposable
{
    Task ToggleAsync(ElementReference offcanvasRef);
    Task ShowAsync(ElementReference offcanvasRef);
    Task CloseAsync(ElementReference offcanvasRef);
}
