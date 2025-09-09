namespace RiRiSharp.Bootstrap.Internals;

internal static class BsIdGenerator
{
    private static readonly Random Random = new();

    internal static string Generate()
    {
        return $"id-{Random.Next()}";
    }
}
