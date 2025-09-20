using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.BaseComponents;

namespace RiRiSharp.Bootstrap.Components.Alert;

public partial class BsAlertHeading : BsChildContentComponent
{
    private const string ALERT_HEADING = "alert-heading";

    protected override void OnParametersSet()
    {
        base.OnParametersSet();
        ThrowIfInvalid(Heading);
    }

    [Parameter]
    public int Heading { get; set; } = 4;

    private static void ThrowIfInvalid(int value)
    {
        if (value is <= 0 or > 5)
        {
            throw new ArgumentOutOfRangeException(nameof(value));
        }
    }
}
