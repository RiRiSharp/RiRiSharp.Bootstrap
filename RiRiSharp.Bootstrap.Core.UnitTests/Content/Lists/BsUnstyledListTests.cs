using RiRiSharp.Bootstrap.Core.Content.Abbreviations;
using RiRiSharp.Bootstrap.Core.Content.Lists;

namespace RiRiSharp.Bootstrap.Core.UnitTests.Content.Lists;

public class BsUnstyledListTests()
    : BootstrapCoreComponentTests<BsUnstyledList>("""<ul class="list-unstyled {0}" {1}></ul>""");