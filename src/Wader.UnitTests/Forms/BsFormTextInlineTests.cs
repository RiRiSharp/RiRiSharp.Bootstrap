using Wader.Forms;

namespace Wader.UnitTests.Forms;

public class BsFormTextInlineTests()
    : BsComponentTests<BsFormTextInline>("""<span class="form-text {0}" {1}></label>""");
