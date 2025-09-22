using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using RiRiSharp.Bootstrap.Internals;

namespace RiRiSharp.Bootstrap.Components.Alert.Internals;

public interface IBsAlertJsFunctions : IBsJsHasDispose
{
    Task DismissAsync(ElementReference alertRef);
    Task RegisterDismissCallbackAsync(ElementReference alertRef, DotNetObjectReference<BsAlert> dotNetRef);
}
