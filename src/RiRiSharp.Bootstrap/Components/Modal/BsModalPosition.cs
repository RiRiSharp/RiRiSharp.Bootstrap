namespace RiRiSharp.Bootstrap.Components.Modal;

public enum BsModalPosition
{
    Top = 0,
    VerticallyCentered = 1,
}

public static class BsModalVerticalPositionExtensions
{
    public static string ToBootstrapClass(this BsModalPosition position)
    {
        return position switch
        {
            BsModalPosition.Top => "",
            BsModalPosition.VerticallyCentered => "modal-dialog-centered",
            _ => throw new ArgumentOutOfRangeException(nameof(position), position, null),
        };
    }
}
