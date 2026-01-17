using Wader.Components.Collapse;
using Wader.Components.Dropdown;

namespace Wader.UnitTests.Components.Dropdown;

public class BsDropdownDividerTests()
    : BsComponentTests<BsDropdownDivider>("""<li><hr class="dropdown-divider {0}" {1}></hr></li>""");
