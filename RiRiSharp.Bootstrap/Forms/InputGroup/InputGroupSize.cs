namespace RiRiSharp.Bootstrap.Forms.InputGroups;

public enum InputGroupSize
{
    Small,
    Regular,
    Large
}

public static class InputGroupSizeExtensions
{
    public static string ToBootstrapClass(this InputGroupSize size)
    {
        return size switch
        {
            InputGroupSize.Small => "input-group-sm",
            InputGroupSize.Regular => "",
            InputGroupSize.Large => "input-group-lg",
            _ => throw new ArgumentOutOfRangeException(nameof(size), size, null)
        };
    }
}