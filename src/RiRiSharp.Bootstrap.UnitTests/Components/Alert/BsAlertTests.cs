using NSubstitute;
using RiRiSharp.Bootstrap.Components.Alert;

namespace RiRiSharp.Bootstrap.UnitTests.Components.Alert;

public class BsAlertTests()
    : BsComponentTests<BsAlert>("""<div role="alert" class="alert alert-primary fade show {0}" {1}></div>""")
{
    private readonly IBsAlertJsFunctions _alertJsFunctionsMock = Substitute.For<IBsAlertJsFunctions>();

    protected override void ConfigureTestContext()
    {
        _ = Services.AddSingleton(_alertJsFunctionsMock);
    }
}
