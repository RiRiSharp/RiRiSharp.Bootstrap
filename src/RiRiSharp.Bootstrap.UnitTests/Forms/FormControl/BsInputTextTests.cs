using RiRiSharp.Bootstrap.Forms.FormControl;

namespace RiRiSharp.Bootstrap.UnitTests.Forms.FormControl;

public class BsInputTextTests() : BsInputBaseComponentTests<BsInputText, string>("""<input class="form-control {0}" type="text" {1}></input>""");