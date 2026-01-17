using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;
using RiRiSharp.Bootstrap.BaseComponents;
using RiRiSharp.Bootstrap.Internals;

namespace RiRiSharp.Bootstrap.Components.NavBar;

public partial class BsNavLink : BsChildContentComponent
{
    [Parameter]
    public string? Classes { get; set; }

    protected override string BsComponentClasses => "nav-link";

    protected override void OnParametersSet()
    {
        SetClasses();
        base.OnParametersSet();
    }

    private void SetClasses()
    {
        var componentSpecificClasses = GetBsComponentSpecificClasses();
        var allClasses = $"{componentSpecificClasses} {Classes}";
        AdditionalAttributes = BsAttributeUtilities.AssignClassNames(AdditionalAttributes, allClasses);
    }

    private static string GetBsComponentSpecificClasses()
    {
        return "nav-link";
    }
}
