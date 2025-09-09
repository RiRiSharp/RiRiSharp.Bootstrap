using Microsoft.AspNetCore.Components;

namespace RiRiSharp.Bootstrap.BaseComponents;

public class BsChildContentComponent : BsComponent, IBsChildContentComponent
{
    [Parameter, EditorRequired]
    public RenderFragment ChildContent { get; set; }
}
