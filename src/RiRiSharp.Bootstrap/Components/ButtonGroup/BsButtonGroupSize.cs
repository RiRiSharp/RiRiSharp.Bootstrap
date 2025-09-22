namespace RiRiSharp.Bootstrap.Components.ButtonGroup;

public enum BsButtonGroupSize
{
    Regular = 0,
    Small = 1,
    Large = 2,
}

public static class BsButtonGroupSizeExtensions
{
    public static string ToBootstrapClass(this BsButtonGroupSize size)
    {
        return size switch
        {
            BsButtonGroupSize.Regular => "",
            BsButtonGroupSize.Small => "btn-group-sm",
            BsButtonGroupSize.Large => "btn-group-lg",
            _ => throw new ArgumentOutOfRangeException(nameof(size), size, null),
        };
    }
}
