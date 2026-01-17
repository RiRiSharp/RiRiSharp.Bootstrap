using Microsoft.AspNetCore.Components;
using Wader.BaseComponents;

namespace Wader.Content.DisplayHeadings;

public partial class BsDisplayHeading : BsChildContentComponent
{
    protected override string BsComponentClasses => Type.ToBootstrapClass();

    [Parameter]
    public BsDisplayHeadingType Type { get; set; }
}
