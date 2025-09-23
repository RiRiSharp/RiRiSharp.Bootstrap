using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.BaseComponents;

namespace RiRiSharp.Bootstrap.Forms.ChecksRadios;

public partial class BsFormCheck : BsChildContentComponent
{
    private readonly string _additionalFormCheckClasses;

    protected override string BsComponentClasses =>
        $"form-check {_additionalFormCheckClasses} {FormCheckOptions.ToBootstrapClass()}";

    public BsFormCheck(string additionalFormCheckClasses = "")
    {
        _additionalFormCheckClasses = additionalFormCheckClasses;
    }

    [Parameter]
    public BsFormCheckOptions FormCheckOptions { get; set; }
}
