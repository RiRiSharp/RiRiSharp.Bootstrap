namespace RiRiSharp.Bootstrap.Layout.Containers;

public partial class BsContainer(string breakpoint) : BsChildContentComponent
{
    public BsContainer() : this(string.Empty)
    {
        
    }

    protected string ContainerClass => string.IsNullOrWhiteSpace(breakpoint) ? "container" : $"container-{breakpoint}";
}