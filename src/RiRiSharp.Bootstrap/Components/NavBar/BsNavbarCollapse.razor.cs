using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.BaseComponents;
using RiRiSharp.Bootstrap.Components.Collapse.Internals;
using RiRiSharp.Bootstrap.Internals.Exceptions;

namespace RiRiSharp.Bootstrap.Components.NavBar;

public partial class BsNavbarCollapse : BsChildContentComponent
{
    internal ElementReference HtmlRef;
    protected override string BsComponentClasses => "collapse navbar-collapse";

    [Inject]
    private IBsCollapseJsFunctions CollapseJsFunctions { get; set; } = null!;

    public async Task ToggleAsync()
    {
        await CollapseJsFunctions.ToggleAsync(HtmlRef);
    }
}
