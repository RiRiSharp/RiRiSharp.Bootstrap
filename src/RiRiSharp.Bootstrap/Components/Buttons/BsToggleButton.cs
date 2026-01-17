using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.Components.Buttons.Internals;
using RiRiSharp.Bootstrap.Internals.Exceptions;

namespace RiRiSharp.Bootstrap.Components.Buttons;

public class BsToggleButton : BsButton, IAsyncDisposable
{
    internal ElementReference HtmlRef;

    [Inject]
    private IBsButtonJsFunctions? ButtonJsFunctions { get; set; }

    public async ValueTask DisposeAsync()
    {
        await DisposeAsync(true);
        GC.SuppressFinalize(this);
    }

    public async Task ToggleAsync()
    {
        BsJsInteractionNotEnabledException.ThrowIfNull(ButtonJsFunctions, nameof(ButtonJsFunctions.ToggleAsync));
        await ButtonJsFunctions.ToggleAsync(HtmlRef);
    }

    private async ValueTask DisposeAsync(bool disposing)
    {
        if (!disposing || ButtonJsFunctions is null)
        {
            return;
        }

        await ButtonJsFunctions.DisposeAsync(HtmlRef);
    }
}
