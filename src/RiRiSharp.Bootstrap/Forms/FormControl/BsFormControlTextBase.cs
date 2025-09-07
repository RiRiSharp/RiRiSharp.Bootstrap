using Microsoft.AspNetCore.Components;

namespace RiRiSharp.Bootstrap.Forms.FormControl;

public abstract class BsFormControlTextBase<TValue> : BsInputBase<TValue>
{
    private readonly string _additionalClasses;

    protected BsFormControlTextBase(string additionalClasses = "")
    {
        if (string.IsNullOrWhiteSpace(additionalClasses))
        {
            _additionalClasses = null;
        }

        _additionalClasses = additionalClasses;
    }

    [Parameter] public BsFormSize FormSize { get; set; } = BsFormSize.Regular;
    [Parameter] public bool ReadonlyPlaintext { get; set; }

    protected override string GetBsComponentSpecificClasses()
    {
        var sizeClass = DetermineSizeClass();
        var formControl = DeterminePlainTextClass();
        return string.Join(' ', formControl, _additionalClasses, sizeClass);
    }

    private string DetermineSizeClass()
    {
        return FormSize.ToBootstrapClass();
    }

    private string DeterminePlainTextClass()
    {
        return ReadonlyPlaintext ? "form-control-plaintext" : "form-control";
    }
}