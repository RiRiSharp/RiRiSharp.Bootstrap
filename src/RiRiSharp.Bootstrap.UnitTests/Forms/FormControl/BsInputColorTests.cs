using System.Drawing;
using RiRiSharp.Bootstrap.Forms.FormControl;

namespace RiRiSharp.Bootstrap.UnitTests.Forms.FormControl;

public class BsInputColorTests()
    : BsInputBaseComponentTests<BsInputColor, Color>(
        """<input class="form-control form-control-color {0}" {1}></input>"""
    )
{
    protected override Dictionary<string, string> AttributesForDefaultTests =>
        new() { ["type"] = "color", ["value"] = "" };

    [Fact]
    public void InputTypeCannotBeOverriden()
    {
        TestForDisallowingOverride("type");
    }
}
