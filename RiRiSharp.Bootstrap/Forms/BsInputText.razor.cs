namespace RiRiSharp.Bootstrap.Forms;

public partial class BsInputText : BsInputBase<string>
{
    protected override bool TryParseValueFromString(string value, out string result, out string validationErrorMessage)
    {
        result = value;
        validationErrorMessage = null;
        return true;
    }
}