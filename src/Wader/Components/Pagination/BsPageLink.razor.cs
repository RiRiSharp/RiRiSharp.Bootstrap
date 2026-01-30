using Wader.BaseComponents;

namespace Wader.Components.Pagination;

public partial class BsPageLink : BsChildContentComponent
{
    protected override string BsComponentClasses => $"page-link {ActiveClass}";
    public bool Active { get; set; }
    private string? ActiveClass => Active ? "active" : null;
    private string? AriaCurrent => Active ? "page" : null;
}
