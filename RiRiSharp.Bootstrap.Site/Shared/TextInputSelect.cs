using RiRiSharp.Bootstrap.Forms;

namespace RiRiSharp.Bootstrap.Site.Shared;

public class TextInputSelect : BsFormSelect<string>
{
    protected override bool TryParseValueFromString(string value, out string result, out string validationErrorMessage)
    {
        result = value;
        validationErrorMessage = null;
        return true;
    }
}