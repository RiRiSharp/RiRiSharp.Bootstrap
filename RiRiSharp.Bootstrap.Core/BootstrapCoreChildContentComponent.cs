using Microsoft.AspNetCore.Components;

namespace RiRiSharp.Bootstrap.Core;

public class BootstrapCoreChildContentComponent : BootstrapCoreComponent
{
    [Parameter, EditorRequired] public RenderFragment ChildContent { get; set; }
}