namespace RiRiSharp.Bootstrap.Components.Modal;

public enum BsModalVerticalPosition
{
    Top = 0,
    VerticallyCentered = 1,
}

public static class BsModalVerticalPositionExtensions
{
    public static string ToBootstrapClass(this BsModalVerticalPosition position)
    {
        return position switch
        {
            BsModalVerticalPosition.Top => "",
            BsModalVerticalPosition.VerticallyCentered => "modal-dialog-centered",
            _ => throw new ArgumentOutOfRangeException(nameof(position), position, null),
        };
    }
}
