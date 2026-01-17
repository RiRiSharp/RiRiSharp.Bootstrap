using Microsoft.AspNetCore.Components;

namespace Wader.BaseComponents;

public interface IBsChildContentComponent : IBsComponent
{
    RenderFragment? ChildContent { get; set; }
}
