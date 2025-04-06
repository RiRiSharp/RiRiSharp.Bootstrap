using RiRiSharp.Bootstrap.Core.Content.Abbreviations;
using RiRiSharp.Bootstrap.Core.Content.Blockquotes;

namespace RiRiSharp.Bootstrap.Core.UnitTests.Content.Blockquotes;

public class BlockquoteTests() : BootstrapCoreComponentTests<Blockquote>(@"<blockquote class=""blockquote {0}"" {1}></blockquote>");