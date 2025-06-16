using RiRiSharp.Bootstrap.Content.Abbreviations;
using RiRiSharp.Bootstrap.Content.Blockquotes;

namespace RiRiSharp.Bootstrap.UnitTests.Content.Blockquotes;

public class BsBlockquoteFooterTests()
    : BsComponentTests<BsBlockquoteFooter>("""<figcaption class="blockquote-footer {0}" {1}></figcaption>""");