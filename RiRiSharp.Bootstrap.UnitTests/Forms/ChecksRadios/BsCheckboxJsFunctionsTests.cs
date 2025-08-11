using RiRiSharp.Bootstrap.Forms.ChecksRadios;
using System;

namespace RiRiSharp.Bootstrap.UnitTests.Forms.ChecksRadios;

public class BsCheckboxJsFunctionsTests
{
    [Fact]
    public void ConstructorWorks()
    {
        var ctx = new TestContext();

        try
        {
            _ = new BsCheckboxJsFunctions(ctx.JSInterop.JSRuntime);
        }
        catch (Exception ex)
        {
            Assert.Fail("Expected no exception, but got: " + ex.Message);
        }
    }
}