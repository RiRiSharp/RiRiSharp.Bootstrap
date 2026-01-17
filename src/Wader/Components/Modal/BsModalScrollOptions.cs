namespace Wader.Components.Modal;

public enum BsModalScrollOptions
{
    WholePage = 0,
    DialogOnly = 1,
}

public static class BsModalScrollOptionsExtensions
{
    public static string ToBootstrapClass(this BsModalScrollOptions options)
    {
        return options switch
        {
            BsModalScrollOptions.WholePage => "",
            BsModalScrollOptions.DialogOnly => "modal-dialog-scrollable",
            _ => throw new ArgumentOutOfRangeException(nameof(options), options, null),
        };
    }
}
