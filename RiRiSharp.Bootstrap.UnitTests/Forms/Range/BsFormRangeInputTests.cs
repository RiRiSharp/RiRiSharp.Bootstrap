using RiRiSharp.Bootstrap.Forms.Range;

namespace RiRiSharp.Bootstrap.UnitTests.Forms.Range;

public class BsFormRangeInputTests() : BsInputBaseComponentTests<BsFormRangeInput<int>, int>("""<input class="form-range {0}" type="range" value="0" {1}>""");