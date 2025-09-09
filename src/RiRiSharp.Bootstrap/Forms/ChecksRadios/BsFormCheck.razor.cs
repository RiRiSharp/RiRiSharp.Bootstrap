using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.BaseComponents;

namespace RiRiSharp.Bootstrap.Forms.ChecksRadios;

public partial class BsFormCheck : BsChildContentComponent
{
    private readonly string _additionalFormCheckClasses;

    public BsFormCheck(string additionalFormCheckClasses = "")
    {
        _additionalFormCheckClasses = additionalFormCheckClasses;
    }

    [Parameter]
    public BsFormCheckOptions FormCheckOptions { get; set; }

    private string CssClass
    {
        get
        {
            var componentSpecificClasses = GetBsComponentSpecificClasses();
            return $"{componentSpecificClasses} {Classes}";
        }
    }

    private string GetBsComponentSpecificClasses()
    {
        var optionsClass = FormCheckOptions.ToBootstrapClass();
        return $"form-check {_additionalFormCheckClasses} {optionsClass}";
    }
}
