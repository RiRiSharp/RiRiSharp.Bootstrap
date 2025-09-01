using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using RiRiSharp.Bootstrap.BaseComponents;
using RiRiSharp.Bootstrap.Internals;

namespace RiRiSharp.Bootstrap.Forms.Select;

// 'multiple' is not supported (yet)
public class BsInputSelect<TValue> : InputSelect<TValue>, IBsChildContentComponent
{
    private const string _formSelect = "form-select";
    [Parameter] public FormSize FormSize { get; set; } = FormSize.Regular;
    [Parameter] public string Classes { get; set; }

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
        return $"{_formSelect} {sizeClass}";
    }

    private string DetermineSizeClass()
    {
        if (FormSize == FormSize.Regular) return "";
        if (FormSize == FormSize.Small) return $"{_formSelect}-sm";
        if (FormSize == FormSize.Large) return $"{_formSelect}-lg";

        throw new ArgumentOutOfRangeException(nameof(FormSize));
    }
}