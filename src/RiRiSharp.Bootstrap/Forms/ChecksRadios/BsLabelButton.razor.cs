using RiRiSharp.Bootstrap.BaseComponents;

namespace RiRiSharp.Bootstrap.Forms.ChecksRadios;

public partial class BsLabelButton : BsChildContentComponent
{
    private const string Button = "btn";
    private readonly string _buttonLabelClasses = Button;

    public BsLabelButton(string additionalButtonLabelClasses = "")
    {
        if (string.IsNullOrWhiteSpace(additionalButtonLabelClasses)) return;
        _buttonLabelClasses = $"{Button} {additionalButtonLabelClasses}";
    }
}