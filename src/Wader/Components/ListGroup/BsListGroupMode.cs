namespace Wader.Components.ListGroup;

public enum BsListGroupMode
{
    Regular = 0,
    Flush = 1,
}

public static class BsListGroupModeExtensions
{
    public static string ToBootstrapClass(this BsListGroupMode mode)
    {
        return mode switch
        {
            BsListGroupMode.Regular => "",
            BsListGroupMode.Flush => "list-group-flush",
            _ => throw new ArgumentOutOfRangeException(nameof(mode), mode, null),
        };
    }
}
