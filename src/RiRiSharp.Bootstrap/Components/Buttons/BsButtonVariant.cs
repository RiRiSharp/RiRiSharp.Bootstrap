namespace RiRiSharp.Bootstrap.Components.Buttons;

public enum BsButtonVariant
{
    None = 0,
    Primary = 1,
    Secondary = 2,
    Success = 3,
    Danger = 4,
    Warning = 5,
    Info = 6,
    Light = 7,
    Dark = 8,
    Link = 9,
    OutlinePrimary = 10,
    OutlineSecondary = 11,
    OutlineSuccess = 12,
    OutlineDanger = 13,
    OutlineWarning = 14,
    OutlineInfo = 15,
    OutlineLight = 16,
    OutlineDark = 17,
}

public static class BsButtonVariantExtensions
{
    public static string ToBootstrapClass(this BsButtonVariant variant)
    {
        return variant switch
        {
            BsButtonVariant.None => "",
            BsButtonVariant.Primary => "btn-primary",
            BsButtonVariant.Secondary => "btn-secondary",
            BsButtonVariant.Success => "btn-success",
            BsButtonVariant.Danger => "btn-danger",
            BsButtonVariant.Warning => "btn-warning",
            BsButtonVariant.Info => "btn-info",
            BsButtonVariant.Light => "btn-light",
            BsButtonVariant.Dark => "btn-dark",
            BsButtonVariant.Link => "btn-link",
            BsButtonVariant.OutlinePrimary => "btn-outline-primary",
            BsButtonVariant.OutlineSecondary => "btn-outline-secondary",
            BsButtonVariant.OutlineSuccess => "btn-outline-success",
            BsButtonVariant.OutlineDanger => "btn-outline-danger",
            BsButtonVariant.OutlineWarning => "btn-outline-warning",
            BsButtonVariant.OutlineInfo => "btn-outline-info",
            BsButtonVariant.OutlineLight => "btn-outline-light",
            BsButtonVariant.OutlineDark => "btn-outline-dark",
            _ => throw new ArgumentOutOfRangeException(nameof(variant), variant, null),
        };
    }
}
