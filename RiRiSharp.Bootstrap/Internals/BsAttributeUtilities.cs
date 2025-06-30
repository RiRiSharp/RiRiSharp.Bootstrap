using System.Globalization;

namespace RiRiSharp.Bootstrap.Internals;

internal static class BsAttributeUtilities
{
    /// <summary>
    /// Combines the class attribute given in the attribute dictionary with the classnames provided.
    /// </summary>
    /// <param name="additionalAttributes">The attribute dictionary</param>
    /// <param name="classNames">CSS classes to add</param>
    /// <returns>A CSS class string containing the combination of the provided classnames and the classes present in the dictionary.</returns>
    internal static string CombineClassNames<T>(T additionalAttributes, string classNames) where T : IEnumerable<KeyValuePair<string, object>>
    {
        var dictionary = additionalAttributes?.ToDictionary() ?? new Dictionary<string, object>();
        return CombineClassNames(dictionary, classNames);
    }

    // Taken from Microsoft.AspNetCore.Components.Forms.AttributeUtilities, licensed under MIT license
    private static string CombineClassNames(Dictionary<string, object> additionalAttributes, string classNames)
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

    /// <summary>
    /// Creates a copy of the attribute dictionary where the classes attribute is overwritten by the provided string class names.
    /// </summary>
    /// <param name="additionalAttributes">The attribute dictionary to create a copy of.</param>
    /// <param name="classNames">The classes which will overwrite to the class attribute of the attribute dictionary</param>
    /// <returns>A copy of the attribute dictionary where the classes attribute is overwritten.</returns>
    internal static IDictionary<string, object> AssignClassNames(
        IDictionary<string, object> additionalAttributes, string classNames)
    {
        var attributes = additionalAttributes?.ToDictionary() ?? new Dictionary<string, object>();
        AssignClassNames(attributes, classNames);
        return attributes;
    }

    /// <summary>
    /// Creates a copy of the attribute dictionary where the classes attribute is overwritten by the provided string class names.
    /// </summary>
    /// <param name="additionalAttributes">The attribute dictionary to create a copy of.</param>
    /// <param name="classNames">The classes which will overwrite to the class attribute of the attribute dictionary</param>
    /// <returns>A copy of the attribute dictionary where the classes attribute is overwritten.</returns>
    internal static IReadOnlyDictionary<string, object> AssignClassNames(
        IReadOnlyDictionary<string, object> additionalAttributes, string classNames)
    {
        var attributes = additionalAttributes?.ToDictionary() ?? new Dictionary<string, object>();
        AssignClassNames(attributes, classNames);
        return attributes;
    }

    private static void AssignClassNames(Dictionary<string, object> additionalAttributes, string classNames)
    {
        // Make sure every class is only mentioned once, otherwise every parameterSet call will re-add some classes
        additionalAttributes["class"] = classNames
            .Split(' ')
            .ToHashSet()
            .Aggregate("", (current, @class) => @class + " " + current);
    }
}