namespace RiRiSharp.Bootstrap.Core.Layout.Containers;

public enum ContainerBreakpoint
{
    Default,
    Sm,
    Md,
    Lg,
    Xl,
    Xxl,
    Fluid
}

public static class ContainerBreakpointExtensions
{
    public static string ToBootstrapClass(this ContainerBreakpoint breakpoint)
    {
        return breakpoint switch
        {
            ContainerBreakpoint.Default => "container",
            ContainerBreakpoint.Sm => "container-sm",
            ContainerBreakpoint.Md => "container-md",
            ContainerBreakpoint.Lg => "container-lg",
            ContainerBreakpoint.Xl => "container-xl",
            ContainerBreakpoint.Xxl => "container-xxl",
            ContainerBreakpoint.Fluid => "container-fluid",
            _ => throw new ArgumentOutOfRangeException(nameof(breakpoint), breakpoint, null)
        };
    }
}