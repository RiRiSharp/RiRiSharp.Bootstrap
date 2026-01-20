namespace Wader.Content.Abbreviations;

public enum BsAbbreviationType
{
    Default = 0,
    Initialism = 1,
}

internal static class AbbreviationTypeExtensions
{
    internal static string ToBootstrapClass(this BsAbbreviationType abbreviationType)
    {
        return abbreviationType switch
        {
            BsAbbreviationType.Default => "",
            BsAbbreviationType.Initialism => "initialism",
            _ => throw new ArgumentOutOfRangeException(nameof(abbreviationType), abbreviationType, null),
        };
    }
}
