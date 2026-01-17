using Wader.Content.TextDecorations;

namespace Wader.UnitTests.Content.TextDecorations;

public class BsUnderlinedTextTests()
    : BsComponentTests<BsUnderlinedText>("""<span class="text-decoration-underline {0}" {1}></span>""");
