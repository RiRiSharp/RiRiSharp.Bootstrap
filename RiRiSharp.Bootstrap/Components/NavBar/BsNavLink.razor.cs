using RiRiSharp.Bootstrap.Internals;

namespace RiRiSharp.Bootstrap.Components.NavBar;

public partial class BsNavLink : BsChildContentComponent
{
    protected override void OnParametersSet()
    {
        base.OnParametersSet();
        AddClass();
    }

    private void AddClass()
    {
        var classesToAdd = $"nav-link {Classes}";
        AdditionalAttributes = BsAttributeUtilities.AddClasses(AdditionalAttributes, classesToAdd);
    }
}