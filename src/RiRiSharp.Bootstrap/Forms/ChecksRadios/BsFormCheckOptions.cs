namespace RiRiSharp.Bootstrap.Forms.ChecksRadios;

public enum BsFormCheckOptions
{
    Stacked,
    Inline,
    Reverse,
}

public static class BsFormCheckOptionsExtensions
{
    public static string ToBootstrapClass(this BsFormCheckOptions formCheckOptions)
    {
        return formCheckOptions switch
        {
            BsFormCheckOptions.Stacked => "",
            BsFormCheckOptions.Inline => "form-check-inline",
            BsFormCheckOptions.Reverse => "form-check-reverse",
            _ => throw new ArgumentOutOfRangeException(nameof(formCheckOptions)),
        };
    }
}
