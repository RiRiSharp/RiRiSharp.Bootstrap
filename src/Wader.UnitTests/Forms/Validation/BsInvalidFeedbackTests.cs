using Wader.Forms.Validation;

namespace Wader.UnitTests.Forms.Validation;

public class BsInvalidFeedbackTests()
    : BsComponentTests<BsInvalidFeedback>("""<div class="invalid-feedback {0}" {1}></div>""");
