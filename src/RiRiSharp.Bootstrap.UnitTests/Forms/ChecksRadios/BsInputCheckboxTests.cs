using RiRiSharp.Bootstrap.Forms.ChecksRadios;

namespace RiRiSharp.Bootstrap.UnitTests.Forms.ChecksRadios;

public class BsButtonCheckCheckboxInputTests()
    : BsInputBaseComponentTests<BsInputCheckbox, bool>("""<input class="form-check-input {0}" {1}></label>""")
{
    protected override Dictionary<string, string> AttributesForDefaultTests => new() { ["type"] = "checkbox" };

    [Fact]
    public void InputTypeCannotBeOverriden()
    {
        TestForDisallowingOverride("type");
    }
}
