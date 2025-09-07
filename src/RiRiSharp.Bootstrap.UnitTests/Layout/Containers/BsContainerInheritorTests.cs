using RiRiSharp.Bootstrap.Layout.Containers;

namespace RiRiSharp.Bootstrap.UnitTests.Layout.Containers;

public class BsContainerSmTests() : BsComponentTests<BsContainerSm>("""<div class="container-sm {0}" {1}></div>""");
public class BsContainerMdTests() : BsComponentTests<BsContainerMd>("""<div class="container-md {0}" {1}></div>""");
public class BsContainerLgTests() : BsComponentTests<BsContainerLg>("""<div class="container-lg {0}" {1}></div>""");
public class BsContainerXlTests() : BsComponentTests<BsContainerXl>("""<div class="container-xl {0}" {1}></div>""");
public class BsContainerXxlTests() : BsComponentTests<BsContainerXxl>("""<div class="container-xxl {0}" {1}></div>""");
public class BsContainerInheritorTests() : BsComponentTests<BsContainerFluid>("""<div class="container-fluid {0}" {1}></div>""");
