using Microsoft.AspNetCore.Components;
using System.Drawing;

namespace RiRiSharp.Bootstrap.Forms;

// Solves https://stackoverflow.com/questions/64052566/is-there-any-blazor-timepicker-and-colorpicker
public partial class BsInputColor() : BsInputBase<Color>("form-control-color")
{
    protected override bool TryParseValueFromString(string value, out Color result, out string validationErrorMessage)
    {
        result = ColorTranslator.FromHtml(value);
        validationErrorMessage = null;
        return true;
    }

    protected override string FormatValueAsString(Color value)
    {
        var htmlColor = ColorTranslator.ToHtml(value);
        return htmlColor;
    }

    private void Change(ChangeEventArgs obj)
    {
        var test = obj.Value?.ToString();
        Console.WriteLine(test);
    }
}