namespace RiRiSharp.Bootstrap.Content.Abbreviations;

public enum BsAbbreviationType
{
    Default,
    Initialism
}

public static class AbbreviationTypeExtensions
{
    public static string ToBootstrapClass(this BsAbbreviationType abbreviationType)
    {
        return abbreviationType switch
        {
            BsAbbreviationType.Default => "",
            BsAbbreviationType.Initialism => "initialism",
            _ => throw new ArgumentOutOfRangeException(nameof(abbreviationType), abbreviationType, null)
        };
    }
}