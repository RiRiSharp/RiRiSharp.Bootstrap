using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using RiRiSharp.Bootstrap.Internals;

namespace RiRiSharp.Bootstrap.Forms;

public class BsInputFile : InputFile, IBsFormControlComponent
{
    [Parameter] public string Classes { get; set; }
    [Parameter] public FormSize FormSize { get; set; } = FormSize.Regular;

    protected override void OnParametersSet()
    {
        base.OnParametersSet();
        SetClasses();
    }

    private void SetClasses()
    {
        var formSizeClass = FormSize.ToBootstrapClass();
        var classesToAdd = $"form-control {formSizeClass} {Classes}";
        AdditionalAttributes = BsAttributeUtilities.AddClasses(AdditionalAttributes, classesToAdd);
    }

}