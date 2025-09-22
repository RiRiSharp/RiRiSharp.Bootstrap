using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using RiRiSharp.Bootstrap.BaseComponents;
using RiRiSharp.Bootstrap.Internals;

namespace RiRiSharp.Bootstrap.Forms.Selects;

/// <summary>
/// Renders an input select list
/// </summary>
/// <typeparam name="TValue">The value type you want to select</typeparam>
public class BsInputSelect<TValue> : InputSelect<TValue>, IBsChildContentComponent
{
    private const string FORM_SELECT = "form-select";

    [Parameter]
    public BsFormSize FormSize { get; set; }

    [Parameter]
    public string? Classes { get; set; }
    public ElementReference HtmlRef => Element.GetValueOrDefault();

    protected override void OnParametersSet()
    {
        base.OnParametersSet();
        SetClasses();
    }

    private void SetClasses()
    {
        var componentSpecificClasses = GetBsComponentSpecificClasses();
        var allClasses = $"{componentSpecificClasses} {Classes}";
        AdditionalAttributes = BsAttributeUtilities.AssignClassNames(AdditionalAttributes, allClasses);
    }

    private string GetBsComponentSpecificClasses()
    {
        var sizeClass = DetermineSizeClass();
        return $"{FORM_SELECT} {sizeClass}";
    }

    private string DetermineSizeClass()
    {
        return FormSize switch
        {
            BsFormSize.Regular => "",
            BsFormSize.Small => $"{FORM_SELECT}-sm",
            BsFormSize.Large => $"{FORM_SELECT}-lg",
            _ => throw new ArgumentOutOfRangeException(nameof(FormSize)),
        };
    }
}
