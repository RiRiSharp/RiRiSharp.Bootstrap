using RiRiSharp.Bootstrap.BaseComponents;

namespace RiRiSharp.Bootstrap.Layout.Containers;

public partial class BsContainer(string breakpoint = "") : BsChildContentComponent
{
    protected override string BsComponentClasses => ContainerClass;
    protected string ContainerClass => string.IsNullOrWhiteSpace(breakpoint) ? "container" : $"container-{breakpoint}";
}
