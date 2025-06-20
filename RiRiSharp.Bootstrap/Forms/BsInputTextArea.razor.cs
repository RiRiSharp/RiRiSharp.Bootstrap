using Microsoft.AspNetCore.Components;

namespace RiRiSharp.Bootstrap.Forms;

public partial class BsInputTextArea : BsInputBase<string>
{
    [Parameter] public string TextInArea { get; set; }
    
    protected override bool TryParseValueFromString(string value, out string result, out string validationErrorMessage)
    {
        result = value;
        validationErrorMessage = null;
        return true;
    }
}