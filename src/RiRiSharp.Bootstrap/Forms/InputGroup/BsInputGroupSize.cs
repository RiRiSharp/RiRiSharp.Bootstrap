namespace RiRiSharp.Bootstrap.Forms.InputGroup;

public enum BsInputGroupSize
{
    Small,
    Regular,
    Large,
}

public static class InputGroupSizeExtensions
{
    public static string ToBootstrapClass(this BsInputGroupSize size)
    {
        return size switch
        {
            BsInputGroupSize.Small => "input-group-sm",
            BsInputGroupSize.Regular => "",
            BsInputGroupSize.Large => "input-group-lg",
            _ => throw new ArgumentOutOfRangeException(nameof(size), size, null),
        };
    }
}
