using RiRiSharp.Bootstrap.Forms.Validation;

namespace RiRiSharp.Bootstrap.UnitTests.Forms.Validation;

public class BsValidationMessageTests() : BsComponentTests<BsValidationMessage<string>>("""<div class="invalid-feedback {0}" {1}></div>""");