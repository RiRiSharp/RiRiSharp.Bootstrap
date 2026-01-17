using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.BaseComponents;
using RiRiSharp.Bootstrap.Internals;

namespace RiRiSharp.Bootstrap.Components.Alert;

public partial class BsAlertHeading : BsChildContentComponent
{
    protected override string BsComponentClasses => "alert-heading";

    [Parameter]
    public int Heading { get; set; } = 4;
}
