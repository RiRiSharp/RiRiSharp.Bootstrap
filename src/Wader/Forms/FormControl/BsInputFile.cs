using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Wader.BaseComponents;
using Wader.Internals;

namespace Wader.Forms.FormControl;

public class BsInputFile : InputFile
{
    [Parameter]
    public string? Classes { get; set; }

    [Parameter]
    public BsFormSize FormSize { get; set; }

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
        var formSizeClass = DetermineSizeClass();
        return $"form-control {formSizeClass}";
    }

    private string DetermineSizeClass()
    {
        return FormSize.ToBootstrapClass();
    }
}
