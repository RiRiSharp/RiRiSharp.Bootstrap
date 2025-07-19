using RiRiSharp.Bootstrap.Forms;
using RiRiSharp.Bootstrap.Forms.FormControl;
using RiRiSharp.Bootstrap.Forms.Select;

namespace RiRiSharp.Bootstrap.Site.Shared;

public class TextInputSelect : BsInputSelect<string>
{
    protected override bool TryParseValueFromString(string value, out string result, out string validationErrorMessage)
    {
        result = value;
        validationErrorMessage = null;
        return true;
    }
}