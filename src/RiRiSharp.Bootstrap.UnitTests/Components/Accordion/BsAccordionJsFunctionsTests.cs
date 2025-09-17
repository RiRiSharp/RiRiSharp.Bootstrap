using RiRiSharp.Bootstrap.Components.Accordion;

namespace RiRiSharp.Bootstrap.UnitTests.Components.Accordion;

public class BsAccordionJsFunctionsTests : BunitContext
{
    [Fact]
    public async Task ConstructorWorksAsync()
    {
        // Arrange + Act
        try
        {
            await using var x = new BsAccordionJsFunctions(JSInterop.JSRuntime);
        }
        catch (Exception ex)
        {
            // Assert
            Assert.Fail($"Exception of type {ex.GetType()} occured with message {ex.Message}");
            throw;
        }
    }
}
