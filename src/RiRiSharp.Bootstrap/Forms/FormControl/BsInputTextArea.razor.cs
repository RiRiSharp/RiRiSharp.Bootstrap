using Microsoft.AspNetCore.Components;

namespace RiRiSharp.Bootstrap.Forms.FormControl;

public partial class BsInputTextArea : BsFormControlTextBase<string>
{
    [Parameter] public string TextInArea { get; set; }
    
    protected override bool TryParseValueFromString(string value, out string result, out string validationErrorMessage)
    {
        result = value;
        validationErrorMessage = null;
        return true;
    }
}