using Microsoft.AspNetCore.Components;

namespace RiRiSharp.Bootstrap.Forms.ChecksRadios;

public partial class BsFormCheck : BsChildContentComponent
{
    private const string _formCheck = "form-check";
    [Parameter] public BsFormCheckOptions BsFormCheckOptions { get; set; }

    protected string BsCssClass
    {
        get => DetermineClasses();
    }

    private string DetermineClasses()
    {
        var optionsClass = DetermineOptionsClass();
        return $"{_formCheck} {optionsClass} {Classes}";
    }

    private string DetermineOptionsClass()
    {
        if (BsFormCheckOptions == BsFormCheckOptions.Regular) return "";
        if (BsFormCheckOptions == BsFormCheckOptions.Inline) return "form-check-inline";
        if (BsFormCheckOptions == BsFormCheckOptions.Reverse) return "form-check-reverse";

        throw new ArgumentOutOfRangeException(nameof(BsFormCheckOptions));
    }
}