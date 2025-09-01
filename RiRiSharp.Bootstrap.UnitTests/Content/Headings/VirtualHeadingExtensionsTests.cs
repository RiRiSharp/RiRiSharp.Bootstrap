﻿using RiRiSharp.Bootstrap.Content.Headings;

namespace RiRiSharp.Bootstrap.UnitTests.Content.Headings;

public class VirtualHeadingExtensionsTests
{
    [Theory]
    [InlineData(BsHeadingType.H1, "h1")]
    [InlineData(BsHeadingType.H2, "h2")]
    [InlineData(BsHeadingType.H3, "h3")]
    [InlineData(BsHeadingType.H4, "h4")]
    [InlineData(BsHeadingType.H5, "h5")]
    [InlineData(BsHeadingType.H6, "h6")]
    public void HeadingTypeGeneratesCorrectClass(BsHeadingType displayHeadingType, string expectedClass)
    {
        var generatedClass = displayHeadingType.ToBootstrapClass();

        Assert.Equal(expectedClass, generatedClass);
    }
}