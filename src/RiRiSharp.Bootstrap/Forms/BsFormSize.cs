namespace RiRiSharp.Bootstrap.Forms;

public enum BsFormSize
{
    Small,
    Regular,
    Large,
}

public static class FormSizeExtensions
{
    public static string ToBootstrapClass(this BsFormSize formSize)
    {
        return formSize switch
        {
            BsFormSize.Regular => "",
            BsFormSize.Small => "form-control-sm",
            BsFormSize.Large => "form-control-lg",
            _ => throw new ArgumentOutOfRangeException(nameof(BsFormSize)),
        };
    }
}
