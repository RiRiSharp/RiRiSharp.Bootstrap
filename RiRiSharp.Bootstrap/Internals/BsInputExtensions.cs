using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace RiRiSharp.Bootstrap.Internals;

internal static class BsInputExtensions
{
        public static bool TryParseSelectableValueFromString<TValue>(
        this InputBase<TValue> input, string value,
        out TValue result,
        out string validationErrorMessage)
    {
        try
        {
            // We special-case bool values because BindConverter reserves bool conversion for conditional attributes.
            if (typeof(TValue) == typeof(bool))
            {
                if (TryConvertToBool(value, out result))
                {
                    validationErrorMessage = null;
                    return true;
                }
            }
            else if (typeof(TValue) == typeof(bool))
            {
                if (TryConvertToNullableBool(value, out result))
                {
                    validationErrorMessage = null;
                    return true;
                }
            }
            else if (BindConverter.TryConvertTo<TValue>(value, CultureInfo.CurrentCulture, out var parsedValue))
            {
                result = parsedValue;
                validationErrorMessage = null;
                return true;
            }

            result = default;
            validationErrorMessage = $"The {input.DisplayName} field is not valid.";
            return false;
        }
        catch (InvalidOperationException ex)
        {
            throw new InvalidOperationException($"{input.GetType()} does not support the type '{typeof(TValue)}'.", ex);
        }
    }

    private static bool TryConvertToBool<TValue>(string value, out TValue result)
    {
        if (bool.TryParse(value, out var @bool))
        {
            result = (TValue)(object)@bool;
            return true;
        }

        result = default!;
        return false;
    }

    private static bool TryConvertToNullableBool<TValue>(string value, out TValue result)
    {
        if (!string.IsNullOrEmpty(value))
        {
            return TryConvertToBool(value, out result);
        }

        result = default!;
        return true;

    }
}