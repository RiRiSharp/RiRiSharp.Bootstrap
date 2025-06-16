using RiRiSharp.Bootstrap.Layout.GridColumns;

namespace RiRiSharp.Bootstrap.UnitTests.Layout.GridColumns;

public class GridStartOptionsExtensionsTests
{
    [Theory]
    [InlineData(GridStartOptions.Start1, "g-start-1")]
    [InlineData(GridStartOptions.Start2, "g-start-2")]
    [InlineData(GridStartOptions.Start3, "g-start-3")]
    [InlineData(GridStartOptions.Start4, "g-start-4")]
    [InlineData(GridStartOptions.Start5, "g-start-5")]
    [InlineData(GridStartOptions.Start6, "g-start-6")]
    [InlineData(GridStartOptions.Start7, "g-start-7")]
    [InlineData(GridStartOptions.Start8, "g-start-8")]
    [InlineData(GridStartOptions.Start9, "g-start-9")]
    [InlineData(GridStartOptions.Start10, "g-start-10")]
    [InlineData(GridStartOptions.Start11, "g-start-11")]
    [InlineData(GridStartOptions.Start12, "g-start-12")]
    public void ColWidthsWork(GridStartOptions gridStartOptions, string expectedClass)
    {
        var generatedClass = gridStartOptions.ToBootstrapClass();
        Assert.Equal(expectedClass, generatedClass);
    }
}