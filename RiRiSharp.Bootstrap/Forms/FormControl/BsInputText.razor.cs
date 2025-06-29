namespace RiRiSharp.Bootstrap.Forms.FormControl;

public partial class BsInputText : BsFormControlBase<string>
{
    protected override bool TryParseValueFromString(string value, out string result, out string validationErrorMessage)
    {
        result = value;
        validationErrorMessage = null;
        return true;
    }
}