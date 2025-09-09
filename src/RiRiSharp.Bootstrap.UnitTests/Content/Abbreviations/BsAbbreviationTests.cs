using RiRiSharp.Bootstrap.Content.Abbreviations;

namespace RiRiSharp.Bootstrap.UnitTests.Content.Abbreviations;

public class BsAbbreviationTests() : BsComponentTests<BsAbbreviation>("""<abbr class=" {0}" {1}></abbr>""")
{
    [Fact]
    public void NullFullNameDoesNotAddAttribute()
    {
        // Arrange
        ConfigureTestContext();
        
        // Act
        var cut = GetCut(parameters => parameters.Add(p => p.FullName, null));

        // Assert
        cut.MarkupMatches(GetExpectedHtml("", ""));
    }
    
    [Theory]
    [InlineData("")]
    [InlineData("SimpleTitle")]
    [InlineData("C0mplex TîtLè ~💪💪")]
    public void FullNameAddsCorrectTitleAttribute(string fullName)
    {
        // Arrange
        ConfigureTestContext();
        var title = $"title=\"{fullName}\"";
        
        // Act
        var cut = GetCut(parameters => parameters.Add(p => p.FullName, fullName));

        // Assert
        cut.MarkupMatches(GetExpectedHtml("", title));
    }
}