using RiRiSharp.Bootstrap.Components.Collapse;
using RiRiSharp.Bootstrap.Components.Dropdown;

namespace RiRiSharp.Bootstrap.UnitTests.Components.Dropdown;

public class BsDropdownDividerTests()
    : BsComponentTests<BsDropdownDivider>("""<li><hr class="dropdown-divider {0}" {1}></hr></li>""");
