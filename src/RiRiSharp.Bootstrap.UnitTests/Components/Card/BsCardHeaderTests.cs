using RiRiSharp.Bootstrap.Components.Card;
using RiRiSharp.Bootstrap.UnitTests;

namespace RiRiSharp.Bootstrap.UnitTests.Components.Card;

public class BsCardHeaderTests() : BsComponentTests<BsCardHeader>("""<div class="card-header {0}" {1}></div>""")
{
    protected override string ClassesForDefaultTests => "card-header";
    protected override Dictionary<string, string> AttributesForDefaultTests => [];
}
