using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using RiRiSharp.Bootstrap.Internals;

namespace RiRiSharp.Bootstrap.Forms;

public abstract class BsInputBase<TValue> : InputBase<TValue>, IBsComponent, IBsFormControlComponent
{
    private readonly string _additionalClasses;

    protected BsInputBase(string additionalClasses = "")
    {
        if (string.IsNullOrWhiteSpace(additionalClasses))
        {
            _additionalClasses = null;
        }

        _additionalClasses = additionalClasses;
    }

    private const string _formControl = "form-control";
    private const string _formControlPlaintext = "form-control-plaintext";

    [Parameter] public string Classes { get; set; }
    [Parameter] public FormSize FormSize { get; set; } = FormSize.Regular;
    [Parameter] public bool ReadonlyPlaintext { get; set; }

    protected override void OnParametersSet()
    {
        base.OnParametersSet();
        SetClass();
    }

    private void SetClass()
    {
        var classes = DetermineClasses();
        AdditionalAttributes = BsAttributeUtilities.AddClasses(AdditionalAttributes, classes);
    }

    protected string DetermineClasses()
    {
        var sizeClass = FormSize.ToBootstrapClass();
        var formControl = DeterminePlainTextClass();
        return string.Join(' ', formControl, _additionalClasses, sizeClass, Classes);
    }

    private string DeterminePlainTextClass()
    {
        return ReadonlyPlaintext ? _formControlPlaintext : _formControl;
    }
}