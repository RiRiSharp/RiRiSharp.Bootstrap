namespace RiRiSharp.Bootstrap.Forms;

public enum FormSize
{
    Small,
    Regular,
    Large
}

public static class FormSizeExtensions
{
    public static string ToBootstrapClass(this FormSize formSize)
    {
        return formSize switch
        {
            FormSize.Small => "form-control-sm",
            FormSize.Regular => null,
            FormSize.Large => "form-control-lg",
            _ => throw new ArgumentOutOfRangeException()
        };
    }
}