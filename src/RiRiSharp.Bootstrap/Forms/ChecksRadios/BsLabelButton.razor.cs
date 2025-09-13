using RiRiSharp.Bootstrap.BaseComponents;

namespace RiRiSharp.Bootstrap.Forms.ChecksRadios;

public partial class BsLabelButton : BsChildContentComponent
{
    private const string BUTTON = "btn";
    private readonly string _buttonLabelClasses = BUTTON;

    public BsLabelButton(string additionalButtonLabelClasses = "")
    {
        if (string.IsNullOrWhiteSpace(additionalButtonLabelClasses))
        {
            return;
        }

        _buttonLabelClasses = $"{BUTTON} {additionalButtonLabelClasses}";
    }
}
