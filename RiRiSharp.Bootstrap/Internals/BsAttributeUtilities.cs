using System.Globalization;

namespace RiRiSharp.Bootstrap.Internals;

internal static class BsAttributeUtilities
{
    internal static string CombineClassNames(IDictionary<string, object> additionalAttributes, string classNames)
    {
        var dictionary = additionalAttributes?.ToDictionary() ?? new Dictionary<string, object>();
        return CombineClassNames(dictionary, classNames);
    }

    internal static string CombineClassNames(IReadOnlyDictionary<string, object> additionalAttributes,
        string classNames)
    {
        var dictionary = additionalAttributes?.ToDictionary() ?? new Dictionary<string, object>();
        return CombineClassNames(dictionary, classNames);
    }

    // Taken from Microsoft.AspNetCore.Components.Forms.AttributeUtilities, licensed under MIT license
    internal static string CombineClassNames(Dictionary<string, object> additionalAttributes, string classNames)
    {
        if (additionalAttributes is null || !additionalAttributes.TryGetValue("class", out var @class))
        {
            return classNames;
        }

        var classAttributeValue = Convert.ToString(@class, CultureInfo.InvariantCulture);

        if (string.IsNullOrEmpty(classAttributeValue))
        {
            return classNames;
        }

        if (string.IsNullOrEmpty(classNames))
        {
            return classAttributeValue;
        }

        return $"{classAttributeValue} {classNames}";
    }
}