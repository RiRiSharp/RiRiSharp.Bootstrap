using RiRiSharp.Bootstrap.BaseComponents;

namespace RiRiSharp.Bootstrap.Content.Images;

public partial class BsImage : BsComponent
{
    protected override string BsComponentClasses => Options.ToBootstrapClass();
}
