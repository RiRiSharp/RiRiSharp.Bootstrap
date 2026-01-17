using Microsoft.AspNetCore.Components;
using Wader.BaseComponents;
using Wader.Internals;

namespace Wader.Components.Alert;

public partial class BsAlertHeading : BsChildContentComponent
{
    protected override string BsComponentClasses => "alert-heading";

    [Parameter]
    public int Heading { get; set; } = 4;
}
