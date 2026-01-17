using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Wader.Internals;

namespace Wader.Components.Alert.Internals;

public interface IBsAlertJsFunctions : IBsJsDisposable
{
    Task DismissAsync(ElementReference alertRef);
    Task RegisterDismissCallbackAsync(ElementReference alertRef, DotNetObjectReference<BsAlert> dotNetRef);
}
