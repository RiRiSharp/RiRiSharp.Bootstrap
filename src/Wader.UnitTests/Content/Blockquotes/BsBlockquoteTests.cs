using Wader.Content.Blockquotes;

namespace Wader.UnitTests.Content.Blockquotes;

public class BsBlockquoteTests()
    : BsComponentTests<BsBlockquote>("""<blockquote class="blockquote {0}" {1}></blockquote>""");
