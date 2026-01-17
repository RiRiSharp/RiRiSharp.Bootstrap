using Microsoft.AspNetCore.Components;
using Wader.BaseComponents;

namespace Wader.Content.Headings;

public partial class BsVirtualHeading : BsChildContentComponent
{
    protected override string BsComponentClasses => Type.ToBootstrapClass();

    [Parameter]
    public BsHeadingType Type { get; set; }
}
