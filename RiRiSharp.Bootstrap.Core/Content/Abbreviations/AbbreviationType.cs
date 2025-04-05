namespace RiRiSharp.Bootstrap.Core.Content.Abbreviations;

public enum AbbreviationType
{
    Default,
    Initialism
}

public static class AbbreviationTypeExtensions
{
    public static string ToBootstrapClass(this AbbreviationType abbreviationType)
    {
        return abbreviationType switch
        {
            AbbreviationType.Default => string.Empty,
            AbbreviationType.Initialism => "initialism",
            _ => throw new ArgumentOutOfRangeException(nameof(abbreviationType), abbreviationType, null)
        };
    }
}