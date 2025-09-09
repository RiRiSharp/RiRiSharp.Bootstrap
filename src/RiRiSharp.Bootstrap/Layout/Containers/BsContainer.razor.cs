using RiRiSharp.Bootstrap.BaseComponents;

namespace RiRiSharp.Bootstrap.Layout.Containers;

public partial class BsContainer(string breakpoint = "") : BsChildContentComponent
{
    protected string ContainerClass =>
        string.IsNullOrWhiteSpace(breakpoint) ? "container" : $"container-{breakpoint}";
}
