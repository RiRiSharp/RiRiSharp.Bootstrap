using RiRiSharp.Bootstrap.Core.Layout.Containers;

namespace RiRiSharp.Bootstrap.Core.UnitTests.Layout.Containers;

public class ContainerBreakpointExtensionsTests
{
    [Theory]
    [InlineData(ContainerBreakpoint.Sm, "container-sm")]
    [InlineData(ContainerBreakpoint.Md, "container-md")]
    [InlineData(ContainerBreakpoint.Lg, "container-lg")]
    [InlineData(ContainerBreakpoint.Xl, "container-xl")]
    [InlineData(ContainerBreakpoint.Xxl, "container-xxl")]
    [InlineData(ContainerBreakpoint.Fluid, "container-fluid")]
    public void BreakpointsWork(ContainerBreakpoint breakpoint, string expectedClass)
    {
        var generatedClass = breakpoint.ToBootstrapClass();
        Assert.Equal(expectedClass, generatedClass);
    }
}