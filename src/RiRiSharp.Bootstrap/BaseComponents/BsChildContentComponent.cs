using Microsoft.AspNetCore.Components;

namespace RiRiSharp.Bootstrap.BaseComponents;

public abstract class BsChildContentComponent : BsComponent, IBsChildContentComponent
{
    [Parameter, EditorRequired]
    public RenderFragment? ChildContent { get; set; }
}
