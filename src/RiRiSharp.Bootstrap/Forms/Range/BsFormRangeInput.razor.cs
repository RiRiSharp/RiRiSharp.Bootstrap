using System.Numerics;

namespace RiRiSharp.Bootstrap.Forms.Range;

public partial class BsFormRangeInput<TValue> : BsInputBase<TValue>
    where TValue : INumber<TValue>
{
    protected override bool TryParseValueFromString(string value, out TValue result, out string validationErrorMessage)
    {
        if (TValue.TryParse(value, null, out result))
        {
            validationErrorMessage = null;
            return true;
        }

        validationErrorMessage = $"The value '{value}' is not valid for type {typeof(TValue).Name}.";
        return false;
    }

    protected override string GetBsComponentSpecificClasses()
    {
        return "form-range";
    }
}
