using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.Components.Buttons.Internals;

namespace RiRiSharp.Bootstrap.Components.Buttons;

public class BsToggleButtonLink : BsButtonLink, IAsyncDisposable
{
    [Inject]
    private IBsButtonJsFunctions ButtonJsFunctions { get; set; } = null!;

    public async Task ToggleAsync()
    {
        await ButtonJsFunctions.ToggleAsync(HtmlRef);
    }

    public async ValueTask DisposeAsync()
    {
        await DisposeAsync(true);
        GC.SuppressFinalize(this);
    }

    private async ValueTask DisposeAsync(bool disposing)
    {
        if (!disposing)
        {
            return;
        }

        await ButtonJsFunctions.DisposeAsync(HtmlRef);
    }
}
