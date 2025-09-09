using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;
using RiRiSharp.Bootstrap.BaseComponents;
using RiRiSharp.Bootstrap.Internals;

namespace RiRiSharp.Bootstrap.Components.NavBar;

public class BsNavLink : NavLink, IBsComponent
{
    [Parameter]
    public string Classes { get; set; }
    public ElementReference HtmlRef => default; // TODO https://github.com/RiRiSharp/RiRiSharp.Bootstrap/issues/5

    protected override void OnParametersSet()
    {
        SetClasses();
        base.OnParametersSet();
    }

    private void SetClasses()
    {
        var componentSpecificClasses = GetBsComponentSpecificClasses();
        var allClasses = $"{componentSpecificClasses} {Classes}";
        AdditionalAttributes = BsAttributeUtilities.AssignClassNames(
            AdditionalAttributes,
            allClasses
        );
    }

    private string GetBsComponentSpecificClasses()
    {
        return "nav-link";
    }
}
