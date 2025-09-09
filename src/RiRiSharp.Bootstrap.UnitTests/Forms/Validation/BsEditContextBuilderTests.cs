using System;
using RiRiSharp.Bootstrap.Forms.Validation;

namespace RiRiSharp.Bootstrap.UnitTests.Forms.Validation;

public class BsEditContextBuilderTests
{
    [Fact]
    public void DoesNotThrowException()
    {
        // Arrange
        var obj = new TestObject();

        // Act
        try
        {
            var sut = BsEditContextBuilder.Build(obj);
        }
        catch (Exception ex)
        {
            // Assert
            Assert.Fail($"Exception of type {ex.GetType()} occured with message {ex.Message}");
        }
    }

    [Fact]
    public void SetsForCorrectObject()
    {
        // Arrange
        var obj = new TestObject();

        // Act
        var sut = BsEditContextBuilder.Build(obj);

        // Assert
        Assert.Equal(obj, sut.Model);
    }

    private class TestObject
    {
        public string SomeProperty { get; set; }
    }
}
