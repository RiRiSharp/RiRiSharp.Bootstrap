using RiRiSharp.Bootstrap.BaseComponents;

namespace RiRiSharp.Bootstrap.Forms.ChecksRadios;

public partial class BsLabelButton : BsChildContentComponent
{
    private const string _button = "btn";
    private readonly string _buttonLabelClasses = _button;

    public BsLabelButton(string additionalButtonLabelClasses = "")
    {
        if (string.IsNullOrWhiteSpace(additionalButtonLabelClasses))
        {
            return;
        }

        _buttonLabelClasses = $"{_button} {additionalButtonLabelClasses}";
    }
}
