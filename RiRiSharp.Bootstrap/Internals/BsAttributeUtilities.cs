namespace RiRiSharp.Bootstrap.Internals;

internal static class BsAttributeUtilities
{
    internal static Dictionary<string, object> AddClasses(IDictionary<string, object> additionalAttributes, string classes)
    {
        var dictionary = additionalAttributes?.ToDictionary() ?? new Dictionary<string, object>();
        return AddClasses(dictionary, classes);
    }
    
    internal static Dictionary<string, object> AddClasses(IReadOnlyDictionary<string, object> additionalAttributes, string classes)
    {
        var dictionary = additionalAttributes?.ToDictionary() ?? new Dictionary<string, object>();
        return AddClasses(dictionary, classes);
    }
    
    internal static Dictionary<string, object> AddClasses(Dictionary<string, object> additionalAttributes, string classes)
    {
        var dictionary = additionalAttributes?.ToDictionary() ?? new Dictionary<string, object>();
        if (dictionary.TryGetValue("class", out var existingClass))
        {
            dictionary["class"] = $"{existingClass} {classes}";
        }
        else
        {
            dictionary["class"] = classes;
        }
        
        return dictionary;
    }
}