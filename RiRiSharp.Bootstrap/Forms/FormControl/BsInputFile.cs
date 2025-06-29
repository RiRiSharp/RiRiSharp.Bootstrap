using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using RiRiSharp.Bootstrap.Internals;

namespace RiRiSharp.Bootstrap.Forms.FormControl;

public class BsInputFile : InputFile
{
    private const string _formControl = "form-control";
    [Parameter] public string Classes { get; set; }
    [Parameter] public FormSize FormSize { get; set; } = FormSize.Regular;

    protected override void OnParametersSet()
    {
        base.OnParametersSet();
        SetClasses();
    }

    private void SetClasses()
    {
        var allClasses = DetermineClasses();
        
        AdditionalAttributes ??= new Dictionary<string, object>();
        
        // Make sure every class is only mentioned once, otherwise every parameterSet call will re-add some classes
        AdditionalAttributes["class"] =  allClasses.Split(' ').ToHashSet().Aggregate(allClasses, (current, @class) => @class + " " + current);
    }

    private string DetermineClasses()
    {
        var formSizeClass = DetermineSizeClass();
        var classesToAdd = $"{_formControl} {formSizeClass} {Classes}";
        var allClasses = BsAttributeUtilities.CombineClassNames(AdditionalAttributes, classesToAdd);
        return allClasses;
    }
    
    private string DetermineSizeClass()
    {
        if (FormSize == FormSize.Regular) return "";
        if (FormSize == FormSize.Small) return $"{_formControl}-sm";
        if (FormSize == FormSize.Large) return $"{_formControl}-lg";
        
        throw new ArgumentOutOfRangeException(nameof(FormSize));
    }
}