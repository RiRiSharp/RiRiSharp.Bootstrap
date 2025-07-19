using Microsoft.AspNetCore.Components;

namespace RiRiSharp.Bootstrap;

public interface IBsChildContentComponent : IBsComponent
{
    public RenderFragment ChildContent { get; set; }
}