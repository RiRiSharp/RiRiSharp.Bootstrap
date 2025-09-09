using RiRiSharp.Bootstrap.Content.Abbreviations;
using RiRiSharp.Bootstrap.Content.Headings;

namespace RiRiSharp.Bootstrap.UnitTests.Content.Headings;

public class BsVirtualHeadingTests()
    : BsComponentTests<BsVirtualHeading>("""<span class="h1 {0}" {1}></span>""");
