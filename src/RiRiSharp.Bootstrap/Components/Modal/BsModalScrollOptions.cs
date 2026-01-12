namespace RiRiSharp.Bootstrap.Components.Modal;

public enum BsModalScrollOptions
{
    Page = 0,
    Dialog = 1,
}

public static class BsModalScrollOptionsExtensions
{
    public static string ToBootstrapClass(this BsModalScrollOptions options)
    {
        return options switch
        {
            BsModalScrollOptions.Page => "",
            BsModalScrollOptions.Dialog => "modal-dialog-scrollable",
            _ => throw new ArgumentOutOfRangeException(nameof(options), options, null),
        };
    }
}
