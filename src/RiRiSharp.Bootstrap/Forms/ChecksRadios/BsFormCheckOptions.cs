namespace RiRiSharp.Bootstrap.Forms.ChecksRadios;

public enum BsFormCheckOptions
{
    Stacked = 0,
    Inline = 1,
    Reverse = 2,
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
