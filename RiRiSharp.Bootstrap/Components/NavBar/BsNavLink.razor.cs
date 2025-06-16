namespace RiRiSharp.Bootstrap.Components.NavBar;

public partial class BsNavLink : BsChildContentComponent
{
    protected override void OnInitialized()
    {
        base.OnInitialized();
        AddClass();
    }

    private void AddClass()
    {
        var dictionary = AdditionalAttributes?.ToDictionary() ?? new Dictionary<string, object>();
        dictionary["class"] = $"nav-link {Classes}";
        AdditionalAttributes = dictionary;
    }
}