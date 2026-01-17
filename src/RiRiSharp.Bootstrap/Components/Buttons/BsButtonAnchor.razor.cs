using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.BaseComponents;
using RiRiSharp.Bootstrap.Components.Buttons.Internals;

namespace RiRiSharp.Bootstrap.Components.Buttons;

public partial class BsButtonAnchor : BsChildContentComponent, IAsyncDisposable
{
    internal ElementReference HtmlRef;

    protected override string BsComponentClasses =>
        $"btn {Variant.ToBootstrapClass()} {Size.ToBootstrapClass()} {DisabledClass} {ActiveClass}";

    [Parameter]
    public BsButtonVariant Variant { get; set; } = BsButtonVariant.Primary;

    [Parameter]
    public BsButtonSize Size { get; set; }

    [Parameter]
    public bool Disabled { get; set; }

    private string DisabledClass => Disabled ? "disabled" : "";

    [Parameter]
    public bool Active { get; set; }

    private string ActiveClass => Active ? "active" : "";

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
