using RiRiSharp.Bootstrap.Core.Content.Abbreviations;
using RiRiSharp.Bootstrap.Core.Content.Lists;

namespace RiRiSharp.Bootstrap.Core.UnitTests.Content.Lists;

public class InlineListItemTests()
    : BootstrapCoreComponentTests<InlineListItem>(@"<li class=""list-inline-item {0}"" {1}></li>");