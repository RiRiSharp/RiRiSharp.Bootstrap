namespace RiRiSharp.Bootstrap.Internals;

internal static class BsAttributeUtilities
{
    /// <summary>
    /// Creates a copy of the attribute dictionary where the classes attribute is overwritten by the provided string class names.
    /// </summary>
    /// <param name="additionalAttributes">The attribute dictionary to create a copy of.</param>
    /// <param name="classNames">The classes which will overwrite to the class attribute of the attribute dictionary</param>
    /// <returns>A copy of the attribute dictionary where the classes attribute is overwritten.</returns>
    internal static IDictionary<string, object> AssignClassNames(
        IDictionary<string, object>? additionalAttributes,
        string classNames
    )
    {
        var attributes = new Dictionary<string, object>();
        if (additionalAttributes is not null)
        {
            attributes = additionalAttributes.ToDictionary();
        }

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
        IReadOnlyDictionary<string, object>? additionalAttributes,
        string? classNames
    )
    {
        var attributes = additionalAttributes?.ToDictionary() ?? [];
        AssignClassNames(attributes, classNames);
        return attributes;
    }

    private static void AssignClassNames(Dictionary<string, object>? additionalAttributes, string? classNames)
    {
        additionalAttributes ??= [];
        classNames ??= "";
        additionalAttributes["class"] = classNames;
    }
}
