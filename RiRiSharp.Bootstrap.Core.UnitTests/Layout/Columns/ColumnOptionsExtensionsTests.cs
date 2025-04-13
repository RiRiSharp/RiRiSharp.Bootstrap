using RiRiSharp.Bootstrap.Core.Layout.Columns;

namespace RiRiSharp.Bootstrap.Core.UnitTests.Layout.Columns;

public class ColumnOptionsExtensionsTests
{
    [Theory]
    [InlineData(ColumnOptions.Sm, "col-sm")]
    [InlineData(ColumnOptions.Md, "col-md")]
    [InlineData(ColumnOptions.Lg, "col-lg")]
    [InlineData(ColumnOptions.Xl, "col-xl")]
    [InlineData(ColumnOptions.Xxl, "col-xxl")]
    public void ColumnBreakpointOptionsGenerateCorrectClass(ColumnOptions breakpointColumnOptions, string expectedClass)
    {
        var generatedClass = breakpointColumnOptions.ToBootstrapColClass();
        Assert.Equal(expectedClass, generatedClass);
    }

    [Theory]
    [InlineData(ColumnOptions.Col1, "col-1")]
    [InlineData(ColumnOptions.Col2, "col-2")]
    [InlineData(ColumnOptions.Col3, "col-3")]
    [InlineData(ColumnOptions.Col4, "col-4")]
    [InlineData(ColumnOptions.Col5, "col-5")]
    [InlineData(ColumnOptions.Col6, "col-6")]
    [InlineData(ColumnOptions.Col7, "col-7")]
    [InlineData(ColumnOptions.Col8, "col-8")]
    [InlineData(ColumnOptions.Col9, "col-9")]
    [InlineData(ColumnOptions.Col10, "col-10")]
    [InlineData(ColumnOptions.Col11, "col-11")]
    [InlineData(ColumnOptions.Col12, "col-12")]
    [InlineData(ColumnOptions.ColAuto, "col-auto")]
    public void ColumnWidthOptionsGenerateCorrectClass(ColumnOptions columnWidthOptions, string expectedClass)
    {
        var generatedClass = columnWidthOptions.ToBootstrapColClass();
        Assert.Equal(expectedClass, generatedClass);
    }

    [Theory]
    [InlineData(ColumnOptions.ColSm4, "col-sm-4")]
    [InlineData(ColumnOptions.ColMd4, "col-md-4")]
    [InlineData(ColumnOptions.ColMd12, "col-md-12")]
    [InlineData(ColumnOptions.ColLgAuto, "col-lg-auto")]
    [InlineData(ColumnOptions.ColLg7, "col-lg-7")]
    [InlineData(ColumnOptions.ColXl7, "col-xl-7")]
    [InlineData(ColumnOptions.ColXxl1, "col-xxl-1")]
    public void ComposedColumnOptionsGenerateCorrectClass(ColumnOptions composedOptions, string expectedClass)
    {
        var generatedClass = composedOptions.ToBootstrapColClass();
        Assert.Equal(expectedClass, generatedClass);
    }
    
    [Theory]
    [InlineData(ColumnOptions.Sm, "offset-sm")]
    [InlineData(ColumnOptions.Md, "offset-md")]
    [InlineData(ColumnOptions.Lg, "offset-lg")]
    [InlineData(ColumnOptions.Xl, "offset-xl")]
    [InlineData(ColumnOptions.Xxl, "offset-xxl")]
    public void OffsetBreakpointOptionsGenerateCorrectClass(ColumnOptions breakpointColumnOptions, string expectedClass)
    {
        var generatedClass = breakpointColumnOptions.ToBootstrapOffsetClass();
        Assert.Equal(expectedClass, generatedClass);
    }

    [Theory]
    [InlineData(ColumnOptions.Col1, "offset-1")]
    [InlineData(ColumnOptions.Col2, "offset-2")]
    [InlineData(ColumnOptions.Col3, "offset-3")]
    [InlineData(ColumnOptions.Col4, "offset-4")]
    [InlineData(ColumnOptions.Col5, "offset-5")]
    [InlineData(ColumnOptions.Col6, "offset-6")]
    [InlineData(ColumnOptions.Col7, "offset-7")]
    [InlineData(ColumnOptions.Col8, "offset-8")]
    [InlineData(ColumnOptions.Col9, "offset-9")]
    [InlineData(ColumnOptions.Col10, "offset-10")]
    [InlineData(ColumnOptions.Col11, "offset-11")]
    [InlineData(ColumnOptions.Col12, "offset-12")]
    [InlineData(ColumnOptions.ColAuto, "offset-auto")]
    public void OffsetWidthOptionsGenerateCorrectClass(ColumnOptions columnWidthOptions, string expectedClass)
    {
        var generatedClass = columnWidthOptions.ToBootstrapOffsetClass();
        Assert.Equal(expectedClass, generatedClass);
    }

    [Theory]
    [InlineData(ColumnOptions.ColSm4, "offset-sm-4")]
    [InlineData(ColumnOptions.ColMd4, "offset-md-4")]
    [InlineData(ColumnOptions.ColMd12, "offset-md-12")]
    [InlineData(ColumnOptions.ColLgAuto, "offset-lg-auto")]
    [InlineData(ColumnOptions.ColLg7, "offset-lg-7")]
    [InlineData(ColumnOptions.ColXl7, "offset-xl-7")]
    [InlineData(ColumnOptions.ColXxl1, "offset-xxl-1")]
    public void ComposedOffsetOptionsGenerateCorrectClass(ColumnOptions composedOptions, string expectedClass)
    {
        var generatedClass = composedOptions.ToBootstrapOffsetClass();
        Assert.Equal(expectedClass, generatedClass);
    }
}