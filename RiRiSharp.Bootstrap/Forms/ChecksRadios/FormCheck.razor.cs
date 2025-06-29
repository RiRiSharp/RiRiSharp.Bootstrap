using Microsoft.AspNetCore.Components;

namespace RiRiSharp.Bootstrap.Forms.ChecksRadios;

public partial class FormCheck : BsChildContentComponent
{
    private const string _formCheck = "form-check";
    [Parameter] public FormCheckOptions FormCheckOptions { get; set; }

    protected string AllClasses
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
        if (FormCheckOptions == FormCheckOptions.Regular) return "";
        if (FormCheckOptions == FormCheckOptions.Inline) return "form-check-inline";
        if (FormCheckOptions == FormCheckOptions.Reverse) return "form-check-reverse";

        throw new ArgumentOutOfRangeException(nameof(FormCheckOptions));
    }
}