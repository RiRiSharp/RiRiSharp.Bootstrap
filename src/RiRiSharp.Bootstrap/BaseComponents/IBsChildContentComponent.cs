using Microsoft.AspNetCore.Components;

namespace RiRiSharp.Bootstrap.BaseComponents;

public interface IBsChildContentComponent : IBsComponent
{
    RenderFragment ChildContent { get; set; }
}
