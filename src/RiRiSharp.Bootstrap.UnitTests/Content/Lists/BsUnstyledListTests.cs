using RiRiSharp.Bootstrap.Content.Abbreviations;
using RiRiSharp.Bootstrap.Content.Lists;

namespace RiRiSharp.Bootstrap.UnitTests.Content.Lists;

public class BsUnstyledListTests()
    : BsComponentTests<BsUnstyledList>("""<ul class="list-unstyled {0}" {1}></ul>""");
