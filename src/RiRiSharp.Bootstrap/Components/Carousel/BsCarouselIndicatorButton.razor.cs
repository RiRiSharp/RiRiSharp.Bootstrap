using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.BaseComponents;

namespace RiRiSharp.Bootstrap.Components.Carousel;

public partial class BsCarouselIndicatorButton : BsChildContentComponent
{
    protected override string BsComponentClasses => ActiveClass;

    [Parameter]
    public bool IsActive { get; set; }

    public string ActiveClass => IsActive ? "active" : "";
}
