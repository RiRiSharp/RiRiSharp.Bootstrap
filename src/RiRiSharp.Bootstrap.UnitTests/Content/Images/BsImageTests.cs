using RiRiSharp.Bootstrap.Content.Images;

namespace RiRiSharp.Bootstrap.UnitTests.Content.Images;

public class BsImageTests() : BsComponentTests<BsImage>("""<img class=" {0}" {1}/>""")
{
    [Fact]
    public void NullSrcDoesNotAddAttribute()
    {
        // Arrange
        ConfigureTestContext();
        
        // Act
        var cut = GetCut(parameters => parameters.Add(p => p.Src, null));

        // Assert
        cut.MarkupMatches(GetExpectedHtml("", ""));
    }
    
    [Theory]
    [InlineData("")]
    [InlineData("source")]
    [InlineData("https://example.com/an-image.jpg")]
    [InlineData("C0mplex TîtLè ~💪💪")]
    public void SrcWorks(string src)
    {
        // Arrange
        ConfigureTestContext();
        var srcAttribute = $"src=\"{src}\"";
        
        // Act
        var cut = GetCut(parameters => parameters.Add(p => p.Src, src));

        // Assert
        cut.MarkupMatches(GetExpectedHtml("", srcAttribute));
    }
}