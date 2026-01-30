using Microsoft.AspNetCore.Components;
using Wader.BaseComponents;
using Wader.Components.Buttons.Internals;
using Wader.Internals.Exceptions;

namespace Wader.Components.Buttons;

public partial class BsButton : BsChildContentComponent, IAsyncDisposable
{
    internal ElementReference HtmlRef;

    protected override string BsComponentClasses =>
        $"btn {Variant.ToBootstrapClass()} {Size.ToBootstrapClass()} {ActiveClass}";

    [Parameter]
    public BsButtonVariant Variant { get; set; } = BsButtonVariant.Primary;

    [Parameter]
    public BsButtonSize Size { get; set; }

    [Parameter]
    public bool Active { get; set; }

    private string? ActiveClass => Active ? "active" : null;

    [Inject]
    private IBsButtonJsFunctions ButtonJsFunctions { get; set; } = null!;

    public async ValueTask DisposeAsync()
    {
        await DisposeAsync(true);
        GC.SuppressFinalize(this);
    }

    public async Task ToggleAsync()
    {
        await ButtonJsFunctions.ToggleAsync(HtmlRef);
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
