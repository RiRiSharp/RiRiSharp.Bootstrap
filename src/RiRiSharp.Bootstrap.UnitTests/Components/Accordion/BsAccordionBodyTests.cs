using RiRiSharp.Bootstrap.Components.Accordion;
using BsAccordionBody = RiRiSharp.Bootstrap.Components.NavBar.BsAccordionBody;

namespace RiRiSharp.Bootstrap.UnitTests.Components.Accordion;

public class BsAccordionBodyTests()
    : BsComponentTests<BsAccordionBody>("""<div class="accordion-body {0}" {1}></div>""");
