﻿using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using RiRiSharp.Bootstrap.Internals;

namespace RiRiSharp.Bootstrap.Forms.FormControl;

public class BsInputFile : InputFile
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