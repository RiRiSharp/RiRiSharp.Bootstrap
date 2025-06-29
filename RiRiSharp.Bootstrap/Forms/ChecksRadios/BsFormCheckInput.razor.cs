namespace RiRiSharp.Bootstrap.Forms.ChecksRadios;

public partial class BsFormCheckInput : BsInputBase<bool>
{
    protected override bool TryParseValueFromString(string value, out bool result, out string validationErrorMessage)
    {
        if (value == "selected")
        {
            result = true;
            validationErrorMessage = null;
            return true;
        }

        if (value == "")
        {
            result = false;
            validationErrorMessage = null;
            return true;
        }
        
        result = false;
        validationErrorMessage = "Could not parse value into bool";
        return false;
    }

    protected override string DetermineClasses()
    {
        return "form-check-input";
    }
}