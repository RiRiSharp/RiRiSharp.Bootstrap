using RiRiSharp.Bootstrap.Components.Card;
using RiRiSharp.Bootstrap.UnitTests;

namespace RiRiSharp.Bootstrap.UnitTests.Components.Card;

public class BsCardTests() : BsComponentTests<BsCard>("""<div class="card {0}" {1}></div>""")
{
    protected override string ClassesForDefaultTests => "card";
    protected override Dictionary<string, string> AttributesForDefaultTests => [];
}
