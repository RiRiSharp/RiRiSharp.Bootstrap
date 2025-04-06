using RiRiSharp.Bootstrap.Core.Content.Abbreviations;
using RiRiSharp.Bootstrap.Core.Content.Lists;

namespace RiRiSharp.Bootstrap.Core.UnitTests.Content.Lists;

public class UnstyledListTests()
    : BootstrapCoreComponentTests<UnstyledList>(@"<ul class=""list-unstyled {0}"" {1}></ul>");