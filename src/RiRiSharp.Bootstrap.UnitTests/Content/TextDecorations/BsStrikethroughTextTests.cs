using RiRiSharp.Bootstrap.Content.Abbreviations;
using RiRiSharp.Bootstrap.Content.TextDecorations;

namespace RiRiSharp.Bootstrap.UnitTests.Content.TextDecorations;

public class BsStrikethroughTextTests()
    : BsComponentTests<BsStrikethroughText>(
        """<span class="text-decoration-line-through {0}" {1}></span>"""
    );
