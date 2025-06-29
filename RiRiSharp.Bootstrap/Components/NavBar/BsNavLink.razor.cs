using RiRiSharp.Bootstrap.Internals;

namespace RiRiSharp.Bootstrap.Components.NavBar;

public partial class BsNavLink : BsChildContentComponent
{
    protected string AllClasses
    {
        get
        {
            var bootstrapClasses = DetermineClasses();
            return BsAttributeUtilities.CombineClassNames(AdditionalAttributes, bootstrapClasses) ?? string.Empty;
        }
    }

    private string DetermineClasses()
    {
        var classesToAdd = $"nav-link {Classes}";
        var allClasses = BsAttributeUtilities.CombineClassNames(AdditionalAttributes, classesToAdd);
        return allClasses;
    }
}