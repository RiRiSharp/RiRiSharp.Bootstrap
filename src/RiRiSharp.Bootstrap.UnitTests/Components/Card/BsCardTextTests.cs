using RiRiSharp.Bootstrap.Components.Card;
using RiRiSharp.Bootstrap.UnitTests;

namespace RiRiSharp.Bootstrap.UnitTests.Components.Card;

public class BsCardTextTests() : BsComponentTests<BsCardText>("""<p class="card-text {0}" {1}></p>""")
{
    protected override string ClassesForDefaultTests => "card-text";
    protected override Dictionary<string, string> AttributesForDefaultTests => [];
}
