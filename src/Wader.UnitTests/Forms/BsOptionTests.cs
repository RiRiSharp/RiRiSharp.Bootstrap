using Wader.Forms;

namespace Wader.UnitTests.Forms;

public class BsOptionTests() : BsComponentTests<BsOption<string>>("""<option class="{0}" value="" {1}>""")
{
    private const string BOUND_VARIABLE = "";

    protected override void BindParameters(ComponentParameterCollectionBuilder<BsOption<string>> parameterBuilder)
    {
        ArgumentNullException.ThrowIfNull(parameterBuilder, nameof(parameterBuilder));
        _ = parameterBuilder.Add(p => p.Value, BOUND_VARIABLE);
    }
}
