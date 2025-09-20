using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.BaseComponents;

namespace RiRiSharp.Bootstrap.Components.Breadcrumb;

public partial class BsBreadcrumbItem : BsChildContentComponent
{
    [Parameter]
    public bool Active { get; set; }
    private string ActiveClass => Active ? "active" : "";
}
