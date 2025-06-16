using Microsoft.AspNetCore.Components;

namespace RiRiSharp.Bootstrap;

public class BsChildContentComponent : BsComponent
{
    [Parameter, EditorRequired] public RenderFragment ChildContent { get; set; }
}