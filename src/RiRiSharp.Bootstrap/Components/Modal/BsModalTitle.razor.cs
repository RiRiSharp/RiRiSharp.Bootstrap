using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.BaseComponents;
using RiRiSharp.Bootstrap.Internals;

namespace RiRiSharp.Bootstrap.Components.Modal;

public partial class BsModalTitle : BsChildContentComponent
{
    protected override string BsComponentClasses => "modal-title";

    [Parameter]
    public int Heading { get; set; } = 5;
}
