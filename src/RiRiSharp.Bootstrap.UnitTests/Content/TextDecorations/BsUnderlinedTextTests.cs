using RiRiSharp.Bootstrap.Content.Abbreviations;
using RiRiSharp.Bootstrap.Content.TextDecorations;

namespace RiRiSharp.Bootstrap.UnitTests.Content.TextDecorations;

public class BsUnderlinedTextTests()
    : BsComponentTests<BsUnderlinedText>(
        """<span class="text-decoration-underline {0}" {1}></span>"""
    );
