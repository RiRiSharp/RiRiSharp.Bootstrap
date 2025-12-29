namespace RiRiSharp.Bootstrap.Components.ListGroup;

public enum BsListType
{
    ContentDivision = 0,
    UnorderedList = 1,
    OrderedList = 2,
}

public static class BsListTypeExtensions
{
    public static string ToBootstrapClass(this BsListType type)
    {
        return type switch
        {
            BsListType.ContentDivision => "",
            BsListType.UnorderedList => "",
            BsListType.OrderedList => "list-group-numbered",
            _ => throw new ArgumentOutOfRangeException(nameof(type), type, null),
        };
    }
}
