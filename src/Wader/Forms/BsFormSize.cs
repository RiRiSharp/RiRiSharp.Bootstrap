namespace Wader.Forms;

public enum BsFormSize
{
    Regular = 0,
    Small = 1,
    Large = 2,
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
            _ => throw new ArgumentOutOfRangeException(nameof(formSize), formSize, null),
        };
    }
}
