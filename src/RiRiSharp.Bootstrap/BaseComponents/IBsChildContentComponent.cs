using Microsoft.AspNetCore.Components;

namespace RiRiSharp.Bootstrap.BaseComponents;

public interface IBsChildContentComponent : IBsComponent
{
    public RenderFragment ChildContent { get; set; }
}