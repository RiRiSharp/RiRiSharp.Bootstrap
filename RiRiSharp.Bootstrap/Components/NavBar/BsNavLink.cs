using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;
using RiRiSharp.Bootstrap.Internals;

namespace RiRiSharp.Bootstrap.Components.NavBar;

public class BsNavLink : NavLink
{
    private const string _navLink = "nav-link";
    [Parameter] public string Classes { get; set; }

    protected override void OnParametersSet()
    {
        SetClasses();
        base.OnParametersSet();
    }

    private void SetClasses()
    {
        var allClasses = GetBsComponentSpecificClasses();
        AdditionalAttributes = BsAttributeUtilities.AssignClassNames(AdditionalAttributes, allClasses);
    }

    private string GetBsComponentSpecificClasses()
    {
        var classesToAdd = $"{_navLink} {Classes}";
        return classesToAdd;
    }
}