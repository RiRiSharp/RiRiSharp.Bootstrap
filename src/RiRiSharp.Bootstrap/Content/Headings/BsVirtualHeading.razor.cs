using RiRiSharp.Bootstrap.BaseComponents;

namespace RiRiSharp.Bootstrap.Content.Headings;

public partial class BsVirtualHeading : BsChildContentComponent
{
    protected override string BsComponentClasses => Type.ToBootstrapClass();
}
