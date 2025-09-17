using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace RiRiSharp.Bootstrap.Components.Alert;

public interface IBsAlertJsFunctions
{
    Task DismissAsync(ElementReference alertRef);
    Task RegisterDismissCallbackAsync(ElementReference alertRef, DotNetObjectReference<BsAlert> dotNetRef);
}
