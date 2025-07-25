﻿using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using RiRiSharp.Bootstrap.Internals;

namespace RiRiSharp.Bootstrap.Forms.Validation;

public class BsValidationMessage<TValue> : ValidationMessage<TValue>, IBsComponent
{
    [Parameter] public string Classes { get; set; }

    protected override void OnParametersSet()
    {
        base.OnParametersSet();
        SetClasses();
    }

    private void SetClasses()
    {
        var allClasses = GetBsComponentSpecificClasses();
        AdditionalAttributes = BsAttributeUtilities.AssignClassNames(AdditionalAttributes, allClasses);
    }

    private string GetBsComponentSpecificClasses()
    {
        return "invalid-feedback";
    }
}