using RiRiSharp.Bootstrap.Content.Tables;
using RiRiSharp.Bootstrap.Forms;

namespace RiRiSharp.Bootstrap.UnitTests.Forms;

public class BsOptionTests()
    : BsComponentTests<BsOption<string>>("""<option class="{0}" value="" {1}>""")
{
    private string _boundVariable = "";

    protected override void BindParameters(
        ComponentParameterCollectionBuilder<BsOption<string>> parameterBuilder
    )
    {
        parameterBuilder.Add(p => p.Value, _boundVariable);
    }
}
