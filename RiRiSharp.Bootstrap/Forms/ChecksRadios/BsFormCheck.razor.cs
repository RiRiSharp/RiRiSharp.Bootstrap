using Microsoft.AspNetCore.Components;

namespace RiRiSharp.Bootstrap.Forms.ChecksRadios;

public partial class BsFormCheck : BsChildContentComponent
{
    private const string _formCheck = "form-check";
    [Parameter] public BsFormCheckOptions FormCheckOptions { get; set; }

    protected string BsCssClass
    {
        get => DetermineClasses();
    }

    private string DetermineClasses()
    {
        var optionsClass = FormCheckOptions.ToBootstrapClass();
        return $"{_formCheck} {optionsClass} {Classes}";
    }
}