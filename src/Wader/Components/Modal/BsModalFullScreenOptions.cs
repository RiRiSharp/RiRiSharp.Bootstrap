namespace Wader.Components.Modal;

public enum BsModalFullScreenOptions
{
    Disable = 0,
    Enable = 1,
}

public static class BsModalFullScreenOptionsExtensions
{
    public static string ToBootstrapClass(this BsModalFullScreenOptions options)
    {
        return options switch
        {
            BsModalFullScreenOptions.Disable => "",
            BsModalFullScreenOptions.Enable => "modal-fullscreen",
            _ => throw new ArgumentOutOfRangeException(nameof(options), options, null),
        };
    }
}
