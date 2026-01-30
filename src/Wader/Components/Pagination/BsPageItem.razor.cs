using Wader.BaseComponents;

namespace Wader.Components.Pagination;

public partial class BsPageItem : BsChildContentComponent
{
    protected override string BsComponentClasses => $"page-item {DisabledClass}";
    public bool Disabled { get; set; }
    private string? DisabledClass => Disabled ? "disabled" : null;
}
