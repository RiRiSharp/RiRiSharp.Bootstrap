using RiRiSharp.Bootstrap.Components.Card;
using RiRiSharp.Bootstrap.UnitTests;

namespace RiRiSharp.Bootstrap.UnitTests.Components.Card;

public class BsCardGroupTests() : BsComponentTests<BsCardGroup>("""<div class="card-group {0}" {1}></div>""")
{
    protected override string ClassesForDefaultTests => "card-group";
    protected override Dictionary<string, string> AttributesForDefaultTests => [];
}
