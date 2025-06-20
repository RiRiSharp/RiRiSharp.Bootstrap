using Microsoft.AspNetCore.Components;

namespace RiRiSharp.Bootstrap;

public interface IBsChildContentComponent
{
    public RenderFragment ChildContent { get; set; }
}