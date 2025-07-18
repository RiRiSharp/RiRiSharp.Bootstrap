using System.Numerics;

namespace RiRiSharp.Bootstrap.Forms.Range;

public partial class BsFormRangeInput<T> : BsInputBase<T> where T : INumber<T>
{
    private const string _formRange = "form-range";

    protected override bool TryParseValueFromString(string value, out T result, out string validationErrorMessage)
    {
        if (T.TryParse(value, null, out result))
        {
            validationErrorMessage = null;
            return true;
        }

        validationErrorMessage = $"The value '{value}' is not valid for type {typeof(T).Name}.";
        return false;
    }

    protected override string DetermineClasses()
    {
        return _formRange;
    }
}