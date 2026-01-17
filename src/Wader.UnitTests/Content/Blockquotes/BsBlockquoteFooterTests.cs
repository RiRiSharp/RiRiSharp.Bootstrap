using Wader.Content.Blockquotes;

namespace Wader.UnitTests.Content.Blockquotes;

public class BsBlockquoteFooterTests()
    : BsComponentTests<BsBlockquoteFooter>("""<figcaption class="blockquote-footer {0}" {1}></figcaption>""");
