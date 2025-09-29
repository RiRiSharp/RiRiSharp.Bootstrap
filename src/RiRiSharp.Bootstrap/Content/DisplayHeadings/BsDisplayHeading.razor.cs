using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.BaseComponents;

namespace RiRiSharp.Bootstrap.Content.DisplayHeadings;

public partial class BsDisplayHeading : BsChildContentComponent
{
    protected override string BsComponentClasses => Type.ToBootstrapClass();

    [Parameter]
    public BsDisplayHeadingType Type { get; set; }
}
