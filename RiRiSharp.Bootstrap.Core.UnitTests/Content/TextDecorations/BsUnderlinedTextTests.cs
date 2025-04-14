using RiRiSharp.Bootstrap.Core.Content.Abbreviations;
using RiRiSharp.Bootstrap.Core.Content.TextDecorations;

namespace RiRiSharp.Bootstrap.Core.UnitTests.Content.TextDecorations;

public class BsUnderlinedTextTests()
    : BootstrapCoreComponentTests<BsUnderlinedText>("""<span class="text-decoration-underline {0}" {1}></span>""");