using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.BaseComponents;

namespace RiRiSharp.Bootstrap.Components.Modal;

public partial class BsModalDialog : BsChildContentComponent
{
    protected override string BsComponentClasses =>
        $"modal-dialog {ScrollOptionsClass} {PositionClass} {FullScreenClass}";

    [Parameter]
    public BsModalScrollOptions ScrollOptions { get; set; }

    private string ScrollOptionsClass => ScrollOptions.ToBootstrapClass();

    [Parameter]
    public BsModalVerticalPosition Position { get; set; }

    //TODO: Add way to add breakpoints
    [Parameter]
    public BsModalFullScreenOptions FullScreen { get; set; }

    private string FullScreenClass => FullScreen.ToBootstrapClass();

    private string PositionClass => Position.ToBootstrapClass();
}
