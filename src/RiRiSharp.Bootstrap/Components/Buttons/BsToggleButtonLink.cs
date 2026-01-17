using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.Components.Buttons.Internals;
using RiRiSharp.Bootstrap.Internals.Exceptions;

namespace RiRiSharp.Bootstrap.Components.Buttons;

public class BsToggleButtonLink : BsButtonLink, IAsyncDisposable
{
    internal ElementReference HtmlRef;

    [Inject]
    private IBsButtonJsFunctions? ButtonFunctions { get; set; }

    public async ValueTask DisposeAsync()
    {
        await DisposeAsync(true);
        GC.SuppressFinalize(this);
    }

    public async Task ToggleAsync()
    {
        BsJsInteractionNotEnabledException.ThrowIfNull(ButtonFunctions, nameof(ButtonFunctions.ToggleAsync));
        await ButtonFunctions.ToggleAsync(HtmlRef);
    }

    private async ValueTask DisposeAsync(bool disposing)
    {
        if (ButtonFunctions is null)
        {
            return;
        }

        if (!disposing)
        {
            return;
        }

        await ButtonFunctions.DisposeAsync(HtmlRef);
    }
}
