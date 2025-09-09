using RiRiSharp.Bootstrap.Forms.ChecksRadios;

namespace RiRiSharp.Bootstrap.UnitTests.Forms.ChecksRadios;

public class BsButtonCheckCheckboxInputTests()
    : BsInputBaseComponentTests<BsInputCheckbox, bool>(
        """<input class="form-check-input {0}" type="checkbox" {1}></label>"""
    );
