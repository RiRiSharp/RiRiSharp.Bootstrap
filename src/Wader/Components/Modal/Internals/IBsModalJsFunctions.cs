using Microsoft.AspNetCore.Components;
using Wader.Internals;

namespace Wader.Components.Modal.Internals;

public interface IBsModalJsFunctions : IBsJsDisposable
{
    Task ToggleAsync(ElementReference modalRef);
    Task ShowAsync(ElementReference modalRef);
    Task CloseAsync(ElementReference modalRef);
    Task HandleUpdateAsync(ElementReference modalRef);
}
