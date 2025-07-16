using Microsoft.AspNetCore.Components;

namespace RiRiSharp.Bootstrap.Forms.ChecksRadios;

public partial class BsFormCheck : BsChildContentComponent
{
    private const string _formCheck = "form-check";

    public BsFormCheck(string additionalFormCheckClasses = "")
    {
        if (string.IsNullOrWhiteSpace(additionalFormCheckClasses)) return;
        _formCheckClasses = $"{_formCheck} {additionalFormCheckClasses}";
    }
    
    private string _formCheckClasses = _formCheck;
    [Parameter] public BsFormCheckOptions FormCheckOptions { get; set; }

    protected string BsCssClass
    {
        get => DetermineClasses();
    }

    private string DetermineClasses()
    {
        var optionsClass = FormCheckOptions.ToBootstrapClass();
        return $"{_formCheckClasses} {optionsClass} {Classes}";
    }
}