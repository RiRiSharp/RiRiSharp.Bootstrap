using Microsoft.AspNetCore.Components;

namespace RiRiSharp.Bootstrap.Forms.FormControl;

public abstract class BsFormControlBase<TValue> : BsInputBase<TValue>
{
    private readonly string _additionalClasses;

    protected BsFormControlBase(string additionalClasses = "")
    {
        if (string.IsNullOrWhiteSpace(additionalClasses))
        {
            _additionalClasses = null;
        }

        _additionalClasses = additionalClasses;
    }

    private const string _formControl = "form-control";
    private const string _formControlPlaintext = "form-control-plaintext";

    [Parameter] public FormSize FormSize { get; set; } = FormSize.Regular;
    [Parameter] public bool ReadonlyPlaintext { get; set; }

    protected override string GetBsComponentSpecificClasses()
    {
        var sizeClass = DetermineSizeClass();
        var formControl = DeterminePlainTextClass();
        return string.Join(' ', formControl, _additionalClasses, sizeClass);
    }

    private string DetermineSizeClass()
    {
        if (FormSize == FormSize.Regular) return "";
        if (FormSize == FormSize.Small) return $"{_formControl}-sm";
        if (FormSize == FormSize.Large) return $"{_formControl}-lg";
        
        throw new ArgumentOutOfRangeException(nameof(FormSize));
    }

    private string DeterminePlainTextClass()
    {
        return ReadonlyPlaintext ? _formControlPlaintext : _formControl;
    }
}