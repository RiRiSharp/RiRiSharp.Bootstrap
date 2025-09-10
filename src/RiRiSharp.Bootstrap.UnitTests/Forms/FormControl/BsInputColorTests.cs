using System.Drawing;
using RiRiSharp.Bootstrap.Forms.FormControl;

namespace RiRiSharp.Bootstrap.UnitTests.Forms.FormControl;

public class BsInputColorTests()
    : BsInputBaseComponentTests<BsInputColor, Color>(
        """<input class="form-control form-control-color {0}" type="color" value="" {1}></input>"""
    );
