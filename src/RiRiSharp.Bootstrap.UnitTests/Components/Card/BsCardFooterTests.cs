using RiRiSharp.Bootstrap.Components.Card;
using RiRiSharp.Bootstrap.UnitTests;

namespace RiRiSharp.Bootstrap.UnitTests.Components.Card;

public class BsCardFooterTests() : BsComponentTests<BsCardFooter>("""<div class="card-footer {0}" {1}></div>""")
{
    protected override string ClassesForDefaultTests => "card-footer";
    protected override Dictionary<string, string> AttributesForDefaultTests => [];
}
