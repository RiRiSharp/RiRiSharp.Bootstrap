using Wader.BaseComponents;

namespace Wader.Layout.Containers;

public partial class BsContainer(string breakpoint = "") : BsChildContentComponent
{
    protected override string BsComponentClasses =>
        string.IsNullOrWhiteSpace(breakpoint) ? "container" : $"container-{breakpoint}";
}
