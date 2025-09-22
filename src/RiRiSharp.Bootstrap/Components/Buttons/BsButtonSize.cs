namespace RiRiSharp.Bootstrap.Components.Buttons;

public enum BsButtonSize
{
    Regular = 0,
    Large = 1,
    Small = 2,
}

public static class BsButtonSizeExtensions
{
    public static string ToBootstrapClass(this BsButtonSize size)
    {
        return size switch
        {
            BsButtonSize.Regular => "",
            BsButtonSize.Large => "btn-lg",
            BsButtonSize.Small => "btn-sm",
            _ => throw new ArgumentOutOfRangeException(nameof(size), size, null),
        };
    }
}
