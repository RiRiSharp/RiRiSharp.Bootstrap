using RiRiSharp.Bootstrap.Core.Layout.GridColumns;

namespace RiRiSharp.Bootstrap.Core.UnitTests.Layout.GridColumns;

public class GridColumnOptionsExtensionsTests
{
        [Theory]
    [InlineData(GridColumnOptions.Sm, "g-col-sm")]
    [InlineData(GridColumnOptions.Md, "g-col-md")]
    [InlineData(GridColumnOptions.Lg, "g-col-lg")]
    [InlineData(GridColumnOptions.Xl, "g-col-xl")]
    [InlineData(GridColumnOptions.Xxl, "g-col-xxl")]
    public void GridBreakpointGenerateCorrectClass(GridColumnOptions gridColumnOptions, string expectedClass)
    {
        var generatedClass = gridColumnOptions.ToBootstrapClass();
        Assert.Equal(expectedClass, generatedClass);
    }

    [Theory]
    [InlineData(GridColumnOptions.GCol1, "g-col-1")]
    [InlineData(GridColumnOptions.GCol2, "g-col-2")]
    [InlineData(GridColumnOptions.GCol3, "g-col-3")]
    [InlineData(GridColumnOptions.GCol4, "g-col-4")]
    [InlineData(GridColumnOptions.GCol5, "g-col-5")]
    [InlineData(GridColumnOptions.GCol6, "g-col-6")]
    [InlineData(GridColumnOptions.GCol7, "g-col-7")]
    [InlineData(GridColumnOptions.GCol8, "g-col-8")]
    [InlineData(GridColumnOptions.GCol9, "g-col-9")]
    [InlineData(GridColumnOptions.GCol10, "g-col-10")]
    [InlineData(GridColumnOptions.GCol11, "g-col-11")]
    [InlineData(GridColumnOptions.GCol12, "g-col-12")]
    [InlineData(GridColumnOptions.GColAuto, "g-col-auto")]
    public void GridColumnWidthsGenerateCorrectClass(GridColumnOptions gridColumnOptions, string expectedClass)
    {
        var generatedClass = gridColumnOptions.ToBootstrapClass();
        Assert.Equal(expectedClass, generatedClass);
    }

    [Theory]
    [InlineData(GridColumnOptions.GColSm4, "g-col-sm-4")]
    [InlineData(GridColumnOptions.GColMd4, "g-col-md-4")]
    [InlineData(GridColumnOptions.GColMd12, "g-col-md-12")]
    [InlineData(GridColumnOptions.GColLgAuto, "g-col-lg-auto")]
    [InlineData(GridColumnOptions.GColLg7, "g-col-lg-7")]
    [InlineData(GridColumnOptions.GColXl7, "g-col-xl-7")]
    [InlineData(GridColumnOptions.GColXxl1, "g-col-xxl-1")]
    public void ComposedGridColumnOptionsGenerateCorrectClass(GridColumnOptions gridColumnOptions, string expectedClass)
    {
        var generatedClass = gridColumnOptions.ToBootstrapClass();
        Assert.Equal(expectedClass, generatedClass);
    }

}