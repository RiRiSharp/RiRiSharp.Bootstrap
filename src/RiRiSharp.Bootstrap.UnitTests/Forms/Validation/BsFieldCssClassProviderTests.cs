using Microsoft.AspNetCore.Components.Forms;
using NSubstitute;
using RiRiSharp.Bootstrap.Forms.Validation;
using System.Collections.Generic;
using System.Linq;

namespace RiRiSharp.Bootstrap.UnitTests.Forms.Validation;

public class BsFieldCssClassProviderTests
{
    [Theory]
    [InlineData(true, true)]
    [InlineData(true, false)]
    [InlineData(false, true)]
    [InlineData(false, false)]
    public void UneditedFieldsReturnNoClass(bool isInvalid, bool showValidInput)
    {
        // Arrange 
        var sut = new BsFieldCssClassProvider(showValidInput);
        
        // Act
        var res = sut.DetermineClass(isModified: false, isInvalid: isInvalid);
        
        // Assert
        Assert.Equal("", res);
    }

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public void WrongFieldsReturnCorrectClass(bool showValidInput)
    {
        // Arrange 
        var sut = new BsFieldCssClassProvider(showValidInput);
        
        // Act
        var res = sut.DetermineClass(isModified: true, isInvalid: true);

        // Assert
        Assert.Equal("is-invalid", res);
    }

    [Theory]
    [InlineData(true, "is-valid")]
    [InlineData(false, "")]
    public void ValidatedFieldsReturnCorrectClass(bool showValidInput, string expected)
    {
        // Arrange 
        var sut = new BsFieldCssClassProvider(showValidInput);
        
        // Act
        var res = sut.DetermineClass(isModified: true, isInvalid: false);
        
        // Assert
        Assert.Equal(expected, res);
    }
    
    private class TestObject
    {
        public string SomeProperty { get; set; }
    }
}