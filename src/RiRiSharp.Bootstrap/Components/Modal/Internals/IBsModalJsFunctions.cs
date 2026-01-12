using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.Internals;

namespace RiRiSharp.Bootstrap.Components.Modal.Internals;

public interface IBsModalJsFunctions : IBsJsDisposable
{
    Task ToggleAsync(ElementReference modalRef);
    Task ShowAsync(ElementReference modalRef);
    Task CloseAsync(ElementReference modalRef);
}
