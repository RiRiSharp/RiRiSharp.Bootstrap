using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.BaseComponents;

namespace RiRiSharp.Bootstrap.Components.Breadcrumb;

public partial class BsBreadcrumbItem : BsChildContentComponent
{
    protected override string BsComponentClasses => $"breadcrumb-item {ActiveClass}";

    [Parameter]
    public bool Active { get; set; }

    private string ActiveClass => Active ? "active" : "";
}
