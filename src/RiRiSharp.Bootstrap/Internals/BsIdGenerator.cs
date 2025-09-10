namespace RiRiSharp.Bootstrap.Internals;

internal static class BsIdGenerator
{
    private static readonly Random _random = new();

    internal static string Generate()
    {
        return $"id-{_random.Next()}";
    }
}
