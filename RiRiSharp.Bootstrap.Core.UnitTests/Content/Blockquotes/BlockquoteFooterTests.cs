using RiRiSharp.Bootstrap.Core.Content.Abbreviations;
using RiRiSharp.Bootstrap.Core.Content.Blockquotes;

namespace RiRiSharp.Bootstrap.Core.UnitTests.Content.Blockquotes;

public class BlockquoteFooterTests()
    : BootstrapCoreComponentTests<BlockquoteFooter>(@"<figcaption class=""blockquote-footer {0}"" {1}></figcaption>");